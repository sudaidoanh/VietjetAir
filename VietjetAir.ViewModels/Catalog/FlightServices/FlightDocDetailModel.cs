using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietjetAir.ViewModels.Catalog.FlightServices
{
    public class FlightDocDetailModel
    {
        public DateOnly Date { get; set; }
        public string TimeOfLoading { get; set; }
        public string TimeOfUnloading { get; set; }
        public string PointOfLoading { get; set; }
        public string PointOfUnloading { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public DateTime CreateDate{ get; set; }
        public string Version { get; set; }
        public string Creator { get; set; }
        public List<PermissionDTO> Permissions { get; set; }
        public List<DocsDTO> Docs { get; set; }
    }
}
