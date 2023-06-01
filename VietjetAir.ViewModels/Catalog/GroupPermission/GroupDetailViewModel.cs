using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietjetAir.ViewModels.Catalog.GroupPermission
{
    public class GroupDetailViewModel
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string Note { get; set; }
        public List<MembersModel> Members { get; set; }
    }
}
