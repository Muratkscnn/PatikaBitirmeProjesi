using DTO.AuthorizationDTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Configuration.Validator.FluentValidation
{
    public class PasswordChangeRequestValidator : AbstractValidator<PasswordChangeRequest>
    {
        public PasswordChangeRequestValidator()
        {
            RuleFor(x => x.NewPassword).NotEmpty().WithMessage("Yeni Şifrenizi Giriniz.");
            RuleFor(x => x.NewPassword).Equal(x => x.RePassword).When(x => !string.IsNullOrWhiteSpace(x.NewPassword)).WithMessage("Şifreler Uyuşmuyor..");
        }
    }
}
