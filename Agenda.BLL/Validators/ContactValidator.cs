using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agenda.Models;
using FluentValidation;

namespace Agenda.BLL.Validators
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.ContactName)
                .NotEmpty().WithMessage("Contact name is required")
                .MaximumLength(100).WithMessage("Contact name must be less than 100 characters");
            RuleFor(x => x.TypeContact)
                .IsInEnum().WithMessage("Invalid contact type");
        }
    }
}
