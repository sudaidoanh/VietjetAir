using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietjetAir.ViewModels.Catalog.GroupPermission
{
    public class CreateGroupRequest
    {
        public string Name { get; set; }
        public string Note { get; set; }
        public string Creator { get; set; }
    }
}
