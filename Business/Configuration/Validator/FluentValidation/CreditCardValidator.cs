using DTO.CreditCard;
using FluentValidation;
using Models.Document;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Configuration.Validator.FluentValidation
{
    public class CreditCardValidator : AbstractValidator<CreditCartRequest>
    {
        public CreditCardValidator()
        {
            RuleFor(x => x.CardNumber).NotEmpty().WithMessage("Kredi Kart Numarası Giriniz.").Length(16).WithMessage("Kredi Kartı numarası 16 karakter olmalıdır.");
            RuleFor(x => x.CustomerName).NotEmpty().WithMessage("Kredi kartı sahibinin ismini giriniz.");
            RuleFor(x => x.ExpireMonth).NotEmpty().WithMessage("Son kullanım Ayını Giriniz").LessThanOrEqualTo(12).WithMessage("Lütfen Geçerli bir Ay giriniz.");
            RuleFor(x => x.ExpireYear).NotEmpty().WithMessage("Son kullanım Yılını Giriniz").GreaterThanOrEqualTo(DateTime.Now.Year).WithMessage("Kartınızın Son Kullanım Tarihi Geçmiştir..");

        }
    }
}
