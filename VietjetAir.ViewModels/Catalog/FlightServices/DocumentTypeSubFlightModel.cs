using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietjetAir.ViewModels.Catalog.FlightServices
{
    public class DocumentTypeSubFlightModel
    {
        public int DocTypeId { get; set; }
        public string DocumentName { get; set; }
        public string Type { get; set; }
        public DateTime CreateDate { get; set; }
        public string Creator { get; set; }
        public string LatestVersion { get; set; }
    }
}
