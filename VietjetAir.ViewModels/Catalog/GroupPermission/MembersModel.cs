using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietjetAir.ViewModels.Catalog.GroupPermission
{
    public class MembersModel
    {
        public Guid MemberId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public IList<string> Permission { get; set; }
    }
}
