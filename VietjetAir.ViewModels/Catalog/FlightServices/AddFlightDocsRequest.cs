using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietjetAir.ViewModels.Catalog.FlightServices
{
    public class AddFlightDocsRequest
    {
        public FlightInfoModel FlightInfo { get; set; }
        public int DocTypeId { get; set; }
        public string Note { get; set; }
        public IFormFile File { get; set; }
    }
}
