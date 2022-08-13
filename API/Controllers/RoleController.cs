using AutoMapper;
using DTO.RoleDTO;
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
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private RoleManager<AppRole> _roleManager;
        private IMapper _mapper;
        private UserManager<AppUser> _userManager;

        public RoleController(RoleManager<AppRole> roleManager, IMapper mapper, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _mapper = mapper;
            _userManager = userManager;
        }


        [HttpPost]
        public async Task<IActionResult> AddRole(RoleAddRequest model)
        {
            var mappedEntity = _mapper.Map<AppRole>(model);
            await _roleManager.CreateAsync(mappedEntity);
            return Ok($"{model.Name} Başarıyla Eklendi..");
        }

        [HttpPost]
        public async Task<IActionResult> AssigningAdminRoleToUser(string userName)
        {
            var user=await _userManager.FindByNameAsync(userName);
            await _userManager.AddToRoleAsync(user, "Admin");
            return Ok($"{userName} Kullanıcısına Admin Rolü Atandı.");
        }
    }
}
