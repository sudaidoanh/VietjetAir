using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietjecAir.Data.Entities
{
    public class Flight
    {
        public string FlightNo { get; set; }
        public DateTime Date { get; set; }
        public string TimeLoading { get; set; }
        public string TimeUnloading { get; set; }
        public string PointofLoading { get; set; }
        public string PointofUnloading { get; set; }
        public List<Document> Documents { get; set; }
    }
}
