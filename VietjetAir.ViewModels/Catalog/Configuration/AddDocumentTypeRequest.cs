using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietjetAir.ViewModels.Catalog.Configuration
{
    public class AddDocumentTypeRequest
    {
        public string Name { get; set; }
        public string Note { get; set; }
        public List<GroupPermissionModel> Permissions { get; set; }
    }
}
