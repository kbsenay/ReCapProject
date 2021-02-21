using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator:AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.CarId).NotEmpty().WithMessage("Araç ID boş olamaz!");
            RuleFor(r => r.CustomerId).NotEmpty().WithMessage("Müşteri ID boş olamaz!");
            RuleFor(r => r.RentDate).NotEmpty().WithMessage("Lütfen kiralama tarihini giriniz!");
            RuleFor(r => r.ReturnDate).NotEmpty().WithMessage("Lütfen dönüş tarihini giriniz!");
        }
    }
}
