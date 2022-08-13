using AutoMapper;
using Business.Abstract;
using DTO.BillOrder;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Authorize(Roles ="Admin")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private IBillOrderService _billorder;
        private IMapper _mapper;

        public AdminController(IBillOrderService billorder, IMapper mapper)
        {
            _billorder = billorder;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUserPaidBills()
        {
            var values = await _billorder.GetAllPaidBills();
            List<PaidBillResponse> response = new List<PaidBillResponse>();
            foreach (var item in values)
            {
                var mappedEntity = _mapper.Map<PaidBillResponse>(item);
                mappedEntity.PaymentDate = ((DateTime)item.PaymentDate).ToString("dd-MMM-yyyy");
                mappedEntity.BlockNo = item.ApartmentInformation.BlockNo;
                mappedEntity.ApartmentNo = item.ApartmentInformation.ApartmentNo;
                response.Add(mappedEntity);
            }
            return Ok(response);
        }
        [HttpGet]
        public async Task<IActionResult> GetPaidBillsByUser(string blockNo,int apartmentNo)
        {
            var values = await _billorder.GetPaidBill(blockNo,apartmentNo);
            List<PaidBillResponse> response = new List<PaidBillResponse>();
            foreach (var item in values)
            {
                var mappedEntity = _mapper.Map<PaidBillResponse>(item);
                mappedEntity.PaymentDate = ((DateTime)item.PaymentDate).ToString("dd-MMM-yyyy");
                mappedEntity.BlockNo = item.ApartmentInformation.BlockNo;
                mappedEntity.ApartmentNo = item.ApartmentInformation.ApartmentNo;
                response.Add(mappedEntity);
               
            }
            return Ok(response);
            
        }
        [HttpGet]
        public async Task<IActionResult> GetTotalPayment()
        {
            var totalPayment = await _billorder.GetTotalPayment();
            return Ok(totalPayment);
        }
        [HttpGet]
        public async Task<IActionResult> GetTotalUnpaidBill()
        {
            var value = await _billorder.GetTotalUnpaidBill();
            return Ok(value);
        }

        [HttpGet]
        public async Task<IActionResult> GetMonthPaid()
        {
            var values = await _billorder.GetMonthPaid();
            List<PaidBillResponse> response = new List<PaidBillResponse>();
            foreach (var item in values)
            {
                var mappedEntity = _mapper.Map<PaidBillResponse>(item);
                mappedEntity.PaymentDate = ((DateTime)item.LastPaymentDate).ToString("dd-MMM-yyyy");
                mappedEntity.BlockNo = item.ApartmentInformation.BlockNo;
                mappedEntity.ApartmentNo = item.ApartmentInformation.ApartmentNo;
                response.Add(mappedEntity);
            }
            return Ok(response);
        }
        [HttpGet]
        public async Task<IActionResult> GetMonthUnPaid()
        {
            var values = await _billorder.GetMonthUnPaid();
            List<UnpaidBillResponse> response = new List<UnpaidBillResponse>();
            foreach (var item in values)
            {
                var mappedEntity = _mapper.Map<UnpaidBillResponse>(item);
                mappedEntity.LastPaymentDate= ((DateTime)item.LastPaymentDate).ToString("dd-MMM-yyyy");
                mappedEntity.BlockNo = item.ApartmentInformation.BlockNo;
                mappedEntity.ApartmentNo = item.ApartmentInformation.ApartmentNo;
                response.Add(mappedEntity);
            }
            return Ok(response);
        }
    }
}
