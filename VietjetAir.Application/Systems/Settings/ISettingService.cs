using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VietjetAir.ViewModels.Common;
using VietjetAir.ViewModels.Systems.Settings;

namespace VietjetAir.Application.Systems.Settings
{
    public interface ISettingService
    {
        Task<AccountSettingModel> GetGeneralSetting();
        Task<bool> ChangeGeneralSetting(string UserUpdate, ChangeGeneralSettingRequest request);
        Task<AccountSettingDTO> GetAccountPagingAsync(GetAccountSettingsRequest request);
        public Task<List<string>> GetEmailAsync();
        public Task<ResultModel<UserAccountModel>> GetAllAccountsAsync(GetAccountSettingsRequest request);
        public Task<bool> ChanggingOwnerAccount(string emailUser, ChangingOwnerAccountRequest request);
        public Task<int> TerminateUserSession(List<string> users);
        public Task<AccountDetailDTO> GetAccountDetail(Guid guid);
        public Task<bool> UpdateUserAccount(Guid guid, UpdateUserAccountRequest request);
        public Task<bool> RemoveUserAccount(Guid guid);
        public Task<bool> ResetPasswordUserAccount(Guid guid);
    }
}
