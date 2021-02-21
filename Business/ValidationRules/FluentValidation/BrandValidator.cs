using Business.Constants;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator:AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(b => b.BrandName).NotEmpty().WithMessage("Marka adı boş olamaz!");
            RuleFor(b => b.BrandName).MinimumLength(3).WithMessage(Messages.BrandNameInvalid);
        }
    }
}
