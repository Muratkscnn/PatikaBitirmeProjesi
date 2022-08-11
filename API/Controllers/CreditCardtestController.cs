using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Document;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditCardtestController : ControllerBase
    {
        private ICreditCardService _card;

        public CreditCardtestController(ICreditCardService card)
        {
            _card = card;
        }

        [HttpPost]
        public async Task<IActionResult> CreditCardAdd()
        {
            CreditCard model = new CreditCard()
            {
                CardNumber = "213123123133",
                CustomerName = "murasst",
                ExpireMonth = 5,
                ExpireYear = 2021,
            };
            _card.Add(model);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetCreditCard()
        {
           
            var values=_card.GetAll();
            return Ok(values);
        }
    }
}
