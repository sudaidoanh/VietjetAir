using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietjetAir.ViewModels.Catalog.FlightServices
{
    public class DocsDTO
    {
        public string DocPath { get; set; }
        public string DocVer { get; set; }
        public DateOnly CreateDate { get; set; }
        public string Creator { get; set; }
    }
}
