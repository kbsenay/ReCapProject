using Business.Constants;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.DailyPrice).GreaterThan(0).WithMessage(Messages.CarPrice);
            RuleFor(c => c.ModelYear).GreaterThan(0).WithMessage("Aracın modeli 0'dan büyük olmalıdır!");
            RuleFor(c => c.Description).MinimumLength(3).WithMessage("Araç açıklaması en az 3 karakter olmaldır!");
            RuleFor(c => c.BrandId).Must(ContainId).WithMessage("Lütfen marka ID no giriniz!");
            RuleFor(c => c.ColorId).Must(ContainId).WithMessage("Lütfen renk ID no giriniz!");

        }
    }
}
