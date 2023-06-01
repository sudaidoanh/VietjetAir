using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietjetAir.ViewModels.Catalog.GroupPermission
{
    public class GroupPermissionViewModel
    {
        public int GroupId { get; set; }
        public string GroupName { get; set;}
        public string Member { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Note{ get; set;}
        public string Creator { get; set;}

    }
}
