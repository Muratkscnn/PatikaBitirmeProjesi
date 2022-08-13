using DTO.BillOrder;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Configuration.Validator.FluentValidation
{
    public class AddDuesRequestValidator : AbstractValidator<AddDuesRequest>
    {
        public AddDuesRequestValidator()
        {
        }
    }
}
