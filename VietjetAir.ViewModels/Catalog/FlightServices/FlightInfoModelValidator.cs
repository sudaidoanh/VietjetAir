using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietjetAir.ViewModels.Catalog.FlightServices
{
    public class FlightInfoModelValidator : AbstractValidator<FlightInfoModel>
    {
        public FlightInfoModelValidator() 
        {
            RuleFor(x => x.Date).GreaterThanOrEqualTo(DateOnly.FromDateTime(DateTime.Now)).WithMessage("Date must greater than or equal to today!");
            RuleFor(x => x.PointofLoading).NotEqual(x => x.PointofUnloading).WithMessage("Point of Loading must diferent from Point of unloading");
        }
    }
}
