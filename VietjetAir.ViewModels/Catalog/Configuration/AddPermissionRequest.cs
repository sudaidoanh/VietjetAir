using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietjetAir.ViewModels.Catalog.Configuration
{
    public class AddPermissionRequest
    {
        public int GroupId { get; set; }
        public string Permission { get; set; }
    }
}
