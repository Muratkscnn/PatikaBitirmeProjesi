using AutoMapper;
using Business.Abstract;
using Business.Configuration.Extensions;
using Business.Configuration.Validator.FluentValidation;
using DTO.CreditCard;
using Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Models.Document;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PayBillController : ControllerBase
    {
        private IBillOrderService _billorder;
        private ICreditCardService _card;
        private IMapper _mapper;
        private UserManager<AppUser> _user;

        public PayBillController(IBillOrderService billorder, ICreditCardService card, IMapper mapper, UserManager<AppUser> user)
        {
            _billorder = billorder;
            _card = card;
            _mapper = mapper;
            _user = user;
        }

        [HttpPost("{billId}")]
        public async Task<IActionResult> PayBillById(int billId,CreditCartRequest model)
        {
            var value = await _billorder.GetById(billId);
            if (value==null)
            {
                return BadRequest("Fatura Bulunamadı..");
            }
            var apartmentInfoId = User.Claims.FirstOrDefault(x => x.Type == "apartmentInfoId").Value;
            if (value.ApartmentInformationId!=int.Parse(apartmentInfoId))
            {
                return BadRequest("Başkasına ait fatura Ödenemez..");
            }
            if (value.PaymentDate!=null)
            {
                return BadRequest("Bu fatura Ödenmiştir..");
            }
            var validator = new CreditCardValidator();
            validator.Validate(model).ThrowIfException();
            var mappedEntity = _mapper.Map<CreditCard>(model);
            _card.Add(mappedEntity);
            value.PaymentDate = DateTime.Now;
            _billorder.Update(value);
            return Ok("Fatura Ödenmiştir");
        }
        [HttpPost]
        public async Task<IActionResult> PayAllBills(CreditCartRequest model)
        {
            var apartmentInfoId = User.Claims.FirstOrDefault(x => x.Type == "apartmentInfoId").Value;
            var unpaidBill = await _billorder.GetUnpaidByUser(int.Parse(apartmentInfoId));
            if (unpaidBill == null)
            {
                return Ok("Ödenmemiş Fatura Bulunmamaktadır.");
            }
            var validator = new CreditCardValidator();
            validator.Validate(model).ThrowIfException();
            var mappedEntity = _mapper.Map<CreditCard>(model);
            _card.Add(mappedEntity);
            foreach (var item in unpaidBill)
            {
                item.PaymentDate = DateTime.Now;
                _billorder.Update(item);
            }
            return Ok("Tüm Faturalar Ödenmiştir..");
        }
    }
}
