using DTO.Apartment;
using Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Configuration.Validator.FluentValidation
{
    public class ApartmentRequestValidator : AbstractValidator<ApartmentRequest>
    {
        public ApartmentRequestValidator()
        {
            RuleFor(x => x.ApartmentNo).NotEmpty().WithMessage("Daire No Giriniz.");
            RuleFor(x => x.ApartmentType).NotEmpty().WithMessage("Daire Tipi Giriniz.");
            RuleFor(x => x.BlockNo).NotEmpty().WithMessage("Blok No Giriniz.");
            RuleFor(x => x.Floor).NotEmpty().WithMessage("Kat Bilgisi Giriniz.");
        }
    }
}
