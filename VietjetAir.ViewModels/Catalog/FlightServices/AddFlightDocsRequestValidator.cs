using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietjetAir.ViewModels.Catalog.FlightServices
{
    public class AddFlightDocsRequestValidator : AbstractValidator<AddFlightDocsRequest>
    {
        public AddFlightDocsRequestValidator() 
        {
            RuleFor(x => new DateOnly(x.FlightInfo.Year, x.FlightInfo.Month, x.FlightInfo.Day)).GreaterThanOrEqualTo(DateOnly.FromDateTime(DateTime.Now)).WithMessage("Date must greater than or equal to today!");
            RuleFor(x => x.FlightInfo.PointofLoading).NotEqual(x => x.FlightInfo.PointofUnloading).WithMessage("Point of Loading must diferent from Point of unloading");
            RuleFor(x => x.FlightInfo.PointofUnloading).NotEqual(x => x.FlightInfo.PointofLoading).WithMessage("Point of Loading must diferent from Point of unloading");
        }
    }
}
