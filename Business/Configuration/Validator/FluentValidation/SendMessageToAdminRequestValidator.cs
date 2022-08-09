using DTO.Message;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Configuration.Validator.FluentValidation
{
    public class SendMessageToAdminRequestValidator : AbstractValidator<SendMessageToAdminRequest>
    {
        public SendMessageToAdminRequestValidator()
        {
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Mesaj Konusu Giriniz.");
            RuleFor(x => x.MessageDetail).NotEmpty().WithMessage("Mesaj İçeriğini Giriniz.");
        }
    }
}
