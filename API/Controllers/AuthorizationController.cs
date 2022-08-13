using AutoMapper;
using Business.Abstract;
using Business.Configuration.Extensions;
using Business.Configuration.Jwt;
using Business.Configuration.Validator.FluentValidation;
using DTO.AuthorizationDTO;
using Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthorizationController : ControllerBase
    {
        private UserManager<AppUser> _userManager;
        private SignInManager<AppUser> _signInManager;
        private IJwtAuthenticationService _jWT;
        private readonly IMapper _mapper;
        private IApartmentInformationService _apartment;

        public AuthorizationController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IJwtAuthenticationService jWT, IMapper mapper, IApartmentInformationService apartment)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _jWT = jWT;
            _mapper = mapper;
            _apartment = apartment;
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            var validator = new RegisterModelValidator();
            validator.Validate(model).ThrowIfException();
            var apartment = await _apartment.GetApartmentByBlockAndApartmentNo(model.BlockNo, model.ApartmentNo);
            if (apartment==null)
            {
                return BadRequest("Girilen Blok No veya Daire Numarasına ait Kayıt Bulunamadı..");
            }
            var mappedEntity = _mapper.Map<AppUser>(model);
            string Password = RandomString(6);
            var result = await _userManager.CreateAsync(mappedEntity, Password);
            if (result.Succeeded)
            {
                var user =await _userManager.FindByNameAsync(model.UserName);
                apartment.AppUserId = user.Id;
                _apartment.Update(apartment);
                return Ok(new { password = Password });
            }
            
            return BadRequest();
        }
        
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
           
            var user = await _userManager.FindByNameAsync(model.UserName);
            if (user == null)
            {
                return BadRequest("Kullanıcı Adı veye Şifre Hatalı");
            }
            var result = await _signInManager.PasswordSignInAsync(user, model.Password, true, false);
            if (result.Succeeded)
            {
                string role =await GetUserRole(user);
                ApartmentInformation apartmentInfo;
                if (await _apartment.GetApartmentIdByUserId(user.Id) == null)
                {
                    if (role=="Admin")
                    {
                         var token = _jWT.Authenticate(user.Id.ToString(),role);
                        return Ok(token);
                    }
                    return BadRequest("Bu kullanıcıya Atanmış bir Daire olmadığından Giriş Yapılamaz..");
                }
                else
                {
                    apartmentInfo = await _apartment.GetApartmentIdByUserId(user.Id);
                }
                var userToken = _jWT.Authenticate(user.Id.ToString(),role, apartmentInfo.ApartmentInformationId.ToString());
                var response = new LoginResponse()
                {
                    ApartmentInfoId = apartmentInfo.ApartmentInformationId,
                    Token=userToken
                };
                return Ok(response);
            }
            return BadRequest("Şifre Hatalı.");
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete()]
        public async Task<IActionResult> DeleteUser(string userName)
        {
            var user =await _userManager.FindByNameAsync(userName);
            await _userManager.DeleteAsync(user);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> PasswordChange(PasswordChangeRequest model)
        {

            var userId = User.Claims.FirstOrDefault(x => x.Type == "id").Value;
            var validator = new PasswordChangeRequestValidator();
            validator.Validate(model).ThrowIfException();
            var user = await _userManager.FindByIdAsync(userId);
            var checkPass=await _userManager.CheckPasswordAsync(user, model.CurrentPassword);
            if (!checkPass)
            {
                return BadRequest("Girdiğiniz şifre hatalı.");
            }
            var result=await _userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);
            if (result.Succeeded)
            {
                return Ok("Şifre Değiştirildi..");
            }
            else
            {
                return BadRequest(result.Errors);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AdminRegister(AdminRegisterRequest model)
        {
            var mappedEntity = _mapper.Map<AppUser>(model);
            var result = await _userManager.CreateAsync(mappedEntity, model.Password);
            if (result.Succeeded)
            {
                var user = await _userManager.FindByNameAsync(model.UserName);
                await _userManager.AddToRoleAsync(user, "Admin");
                return Ok("Admin Rolündeki Kullanıcı Oluşturuldu..");
            }
            return BadRequest();
        }






        private async Task<string> GetUserRole(AppUser user)
        {
            var roles = await _userManager.GetRolesAsync(user);
            string role = "";
            if (roles.Count==0)
            {
                role = "Üye";
            }
            else
            {
                role = "Admin";
            }
            return role;
        }

        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
