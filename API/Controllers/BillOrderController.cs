using AutoMapper;
using Business.Abstract;
using Business.Configuration.Extensions;
using Business.Configuration.Validator.FluentValidation;
using DTO.BillOrder;
using Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BillOrderController : ControllerBase
    {
        private IBillOrderService _billOrder;
        private readonly IMapper _mapper;
        private IApartmentInformationService _apartment;

        public BillOrderController(IBillOrderService billOrder, IMapper mapper, IApartmentInformationService apartment)
        {
            _billOrder = billOrder;
            _mapper = mapper;
            _apartment = apartment;
        }

        [HttpPost]
        public async Task<IActionResult> BillOrderAddByApartmentID(BillOrderAddByApartmentIdRequest model)
        {
            var validator = new BillOrderAddByApartmentIdRequestValidator();
            validator.Validate(model).ThrowIfException();
            DateTime.Parse(model.LastPaymentDate);
            var mappedEntity = _mapper.Map<BillOrder>(model);
            await _billOrder.Add(mappedEntity);
            return Ok(mappedEntity);
        }
        [HttpPost]
        public async Task<IActionResult> BillOrderAddAllApartment(BillOrderAddAllApartmentRequest model)
        {
            var validator = new BillOrderAddAllApartmentRequestValidator();
            validator.Validate(model).ThrowIfException();
            DateTime.Parse(model.LastPaymentDate);
            var apartmentList = await _apartment.GetList();
            foreach (var item in apartmentList)
            {
                var mappedEntity = _mapper.Map<BillOrder>(model);
                mappedEntity.ApartmentInformationId = item.ApartmentInformationId;
                await _billOrder.Add(mappedEntity);
            }
            return Ok("Tüm Dairelere Fatura Tanımlaması Yapıldı..");
        }

        [HttpGet]
        public async Task<IActionResult> GetUnpaidAllApartment()
        {
            var unpaidBill = await _billOrder.GetUnpaidAllApartment();
            var result = new List<UnpaidBillResponse>();
            foreach (var item in unpaidBill)
            {
                ((DateTime)item.LastPaymentDate).ToString("dd-MMM-yyyy");
                var mappedEntity = _mapper.Map<UnpaidBillResponse>(item);
                result.Add(mappedEntity);
            }
            return Ok(result);
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetUnpaidBillByUser()
        {
            var apartmentInfoId = User.Claims.FirstOrDefault(x => x.Type == "apartmentInfoId").Value;

            var unpaidBill = await _billOrder.GetUnpaidByUser(int.Parse(apartmentInfoId));
            var result = new List<UnpaidBillResponse>();
            foreach (var item in unpaidBill)
            {
                var mappedEntity = _mapper.Map<UnpaidBillResponse>(item);
                mappedEntity.LastPaymentDate = ((DateTime)item.LastPaymentDate).ToString("dd-MMM-yyyy");
                result.Add(mappedEntity);
            }
            return Ok(result);
        }

    }
}
