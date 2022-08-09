using DTO.BillOrder;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Configuration.Validator.FluentValidation
{
    public class BillOrderAddByApartmentIdRequestValidator : AbstractValidator<BillOrderAddByApartmentIdRequest>
    {
        public BillOrderAddByApartmentIdRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Fatura Adını Giriniz.");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fatur Ücretini Giriniz.");
            RuleFor(x => x.LastPaymentDate).NotEmpty().WithMessage("Son Ödeme Tarihi Giriniz.");
            RuleFor(x => x.ApartmentInformationId).NotEmpty().WithMessage("Faturanın Atanacağı Daire Id Giriniz.");
        }
    }
}
