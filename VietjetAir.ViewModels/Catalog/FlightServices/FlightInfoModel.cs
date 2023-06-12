using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietjetAir.ViewModels.Catalog.FlightServices
{
    public class FlightInfoModel
    {
        public string FlightNo { get; set; }
        public DateOnly Date { get; set; }
        public string PointofLoading { get; set; }
        public string PointofUnloading { get; set; }
    }
}
