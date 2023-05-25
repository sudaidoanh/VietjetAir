using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietjecAir.Data.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string Address { get; set; }
        public string FullName { get; set; }
    }
}
