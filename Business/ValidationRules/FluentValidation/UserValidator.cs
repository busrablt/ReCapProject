using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.UserId).Empty();
            RuleFor(u => u.LastName).NotEmpty();
            RuleFor(u => u.LastName).NotEmpty();
            RuleFor(u => u.Password).NotEmpty().MinimumLength(8);
            RuleFor(u => u.Email).NotEmpty().EmailAddress();
           
        }
    }
}
