using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VietjetAir.ViewModels.Common;

namespace VietjetAir.ViewModels.Catalog.Configuration
{
    public class DocTypeDetailViewModel
    {
        public int DocumentTypeId { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public List<GroupPermissionModel> Permissions { get; set; }
        public List<GroupModel> Groups { get; set; }
    }
}
