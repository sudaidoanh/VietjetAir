using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VietjetAir.ViewModels.Common;

namespace VietjetAir.ViewModels.Systems.Settings
{
    public class AccountSettingDTO
    {
        public string CurrentOwner { get; set; }
        public string CurrentOwnerName { get; set; }
        public List<string> ListEmailUser { get; set; }
        public ResultModel<UserAccountModel> AllAccounts { get; set; }
    }
}
