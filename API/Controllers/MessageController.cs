using AutoMapper;
using Business.Abstract;
using DTO.Message;
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
    public class MessageController : ControllerBase
    {
        private IMessageService _msg;
        private IMapper _mapper;
        private UserManager<AppUser> _userManager;

        public MessageController(IMessageService msg, IMapper mapper, UserManager<AppUser> userManager)
        {
            _msg = msg;
            _mapper = mapper;
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> SendMessageToAdmin(SendMessageToAdminRequest model)
        {
            var userId = User.Claims.FirstOrDefault(x => x.Type == "id").Value;
            Message mesage = new Message()
            {
                Subject = model.Subject,
                MessageDetails = model.MessageDetail,
                MessageDate = DateTime.Now,
                MessageStatus = false,
                AppUserId = int.Parse(userId),
            };
            await _msg.Add(mesage);
            return Ok("Admine Mesaj Gönderilmiştir..");
        }
        [Authorize(Roles ="Admin")]
        [HttpGet]
        public async Task<IActionResult> GetAllMessages()
        {
            var values = await _msg.GetList();
            return Ok(values);
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> GetUnReadMessage()
        {
            var values = await _msg.GetUnReadMessage();
            return Ok(values);
        }
        [Authorize(Roles = "Admin")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMessageById(int id)
        {
            var value = await _msg.GetById(id);
            value.MessageStatus = true;
            _msg.Update(value);
            return Ok(value);
        }


    }
}
