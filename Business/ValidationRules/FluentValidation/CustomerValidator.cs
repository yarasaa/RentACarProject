using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(cs => cs.CustomerId).NotEmpty();
            RuleFor(cs => cs.CompanyName).NotEmpty();
            RuleFor(cs => cs.CompanyName).MinimumLength(2);
        }
    }
}
