using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietjecAir.Data.Entities
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public string Creator { get; set; }
        public string Note { get; set; }
        public List<GroupMember> groupMembers { get; set; }
    }
}
