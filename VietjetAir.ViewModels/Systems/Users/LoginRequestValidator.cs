using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietjetAir.ViewModels.Systems.Users
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator() 
        {
            RuleFor( x => x.Email ).NotEmpty().WithMessage("Email is required")
                .EmailAddress().WithMessage("Not an email")
                .Matches(@"^([\w\.\-]+)@vietjetair.com$").WithMessage("Not a domain email");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required")
                .MinimumLength(8).WithMessage("Password required atlest 8 charaters")
                .MaximumLength(35).WithMessage("Password required under 35 characters");
        }

    }
}
