using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietjetAir.ViewModels.Systems.Settings
{
    public class ChangingOwnerAccountRequest
    {
        public string Account { get; set; }
        public string CurrentOwnerPassword { get; set; }
    }
}
