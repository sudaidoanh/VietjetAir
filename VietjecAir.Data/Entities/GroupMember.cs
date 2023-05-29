using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietjecAir.Data.Entities
{
    public class GroupMember
    {
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public Guid UserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
