using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietjecAir.Data.Entities
{
    public class System
    {
        public int Id { get; set; }
        public string Theme { get; set; }
        public string LogoPath { get; set; }
        public long LogoSize { get; set; }
        public DateTime Updated { get; set; }
        public string UserUpdate { get; set; }
        public bool CapchaEnabled { get; set; }
    }
}
