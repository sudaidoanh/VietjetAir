using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietjetAir.ViewModels.Catalog.FlightServices
{
    public class AllFlightModel
    {
        public string FlightNo { get; set; }
        public string Route { get; set; }
        public DateOnly DepartureDate { get; set; }
        public int ToTalDocuments { get; set; }
        public List<DocumentTypeSubFlightModel> Documents { get; set; }

    }
}
