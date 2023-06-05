using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietjetAir.ViewModels.Systems.Settings
{
    public class ChangeGeneralSettingRequest
    {
        public string Theme { get; set; }
        public IFormFile LogoImage { get; set; }
        public bool CapchaEnabled { get; set; }
    }
}
