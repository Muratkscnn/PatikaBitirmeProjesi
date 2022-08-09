using DTO.AuthorizationDTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Configuration.Validator.FluentValidation
{
    public class RegisterModelValidator : AbstractValidator<RegisterModel>
    {
        public RegisterModelValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("İsminizi Giriniz.");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("SoyAd Giriniz.");
            RuleFor(x => x.Email).EmailAddress().NotEmpty();
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adı Giriniz.");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Telefon Numarası Giriniz.");
            RuleFor(x => x.TcNo).NotEmpty().WithMessage("Türkiye Cumhuriyeti Kimlik Numarası Giriniz.");

        }
    }
}
