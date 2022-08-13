using AutoMapper;
using DTO.Apartment;
using DTO.AuthorizationDTO;
using DTO.BillOrder;
using DTO.CreditCard;
using DTO.RoleDTO;
using Entity;
using Models.Document;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Configuration.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<RegisterModel, AppUser>();
            CreateMap<AdminRegisterRequest, AppUser>();
            CreateMap<ApartmentRequest, ApartmentInformation>();
            CreateMap<BillOrderAddByApartmentIdRequest, BillOrder>();
            CreateMap<BillOrderAddAllApartmentRequest, BillOrder>();
            CreateMap<AddDuesRequest, BillOrder>();
            CreateMap<BillOrder, UnpaidBillResponse>();
            CreateMap<RoleAddRequest, AppRole>();
            CreateMap<CreditCartRequest, CreditCard>();
            CreateMap<BillOrder, PaidBillResponse>();
        }
    }
}
