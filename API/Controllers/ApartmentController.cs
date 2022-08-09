using AutoMapper;
using Business.Abstract;
using Business.Configuration.Extensions;
using Business.Configuration.Validator.FluentValidation;
using DTO.Apartment;
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
    public class ApartmentController : ControllerBase
    {
        private IApartmentInformationService _apartment;
        private readonly IMapper _mapper;

        public ApartmentController(IApartmentInformationService apartment, IMapper mapper)
        {
            _apartment = apartment;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetApartmentList()
        {
            var result = await _apartment.GetList();
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> ApartmentAdd(ApartmentRequest model)
        {
            var validator = new ApartmentRequestValidator();
            validator.Validate(model).ThrowIfException();
            var mappedEntity = _mapper.Map<ApartmentInformation>(model);
            if (mappedEntity.AppUserId==0)
            {
                mappedEntity.AppUserId = null;
            }
            await _apartment.Add(mappedEntity);
            return Ok(mappedEntity);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> ApartmentUpdate(int id,ApartmentRequest model)
        {
            var entity = await _apartment.GetById(id);
            var validator = new ApartmentRequestValidator();
            validator.Validate(model).ThrowIfException();
            if (entity.ApartmentInformationId!=id)
            {
                return BadRequest($"Id={id} Daire Bulanamadı..");
            }

            //var mappedEntity = _mapper.Map<ApartmentInformation>(model);
            //mappedEntity.ApartmentInformationId = entity.ApartmentInformationId;
            entity.ApartmentNo = model.ApartmentNo;
            entity.ApartmentType = model.ApartmentType;
            entity.AppUserId = model.AppUserId;
            entity.BlockNo = model.BlockNo;
            entity.Floor = model.Floor;
            _apartment.Update(entity);
            return Ok(entity);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> ApartmentDelete(int id)
        {
            var apartment = await _apartment.GetById(id);
            if (apartment==null)
            {
                return BadRequest($"Id={id} Daire Bulanamadı..");
            }
            _apartment.Delete(apartment);
            return Ok($"Id={id} Daire Sitemden Silindi.");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAparmentInformationById(int id)
        {
            var apartment = await _apartment.GetById(id);
            if (apartment==null)
            {
                return BadRequest($"Id={id} Daire Bulanamadı..");
            }
            return Ok(apartment);
        }
    }
}
