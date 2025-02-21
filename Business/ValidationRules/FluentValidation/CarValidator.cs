﻿using System;
using System.Collections.Generic;
using System.Text;
using Entity.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.BrandId).NotEmpty();
            RuleFor(c => c.Name).NotEmpty().MinimumLength(2);
            RuleFor(c => c.ColorId).NotEmpty();
            RuleFor(c => c.DailyPrice).NotEmpty().GreaterThan(0);
            RuleFor(c => c.Description).NotEmpty();
        }
    }
}
