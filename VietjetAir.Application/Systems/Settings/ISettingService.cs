using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VietjetAir.ViewModels.Systems.Settings;

namespace VietjetAir.Application.Systems.Settings
{
    public interface ISettingService
    {
        Task<GetGeneralSettingRequest> GetGeneralSetting();
        Task<bool> ChangeGeneralSetting(string UserUpdate, ChangeGeneralSettingRequest request);
    }
}
