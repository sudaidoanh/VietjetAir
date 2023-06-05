using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VietjetAir.ViewModels.Catalog.GroupPermission;
using VietjetAir.ViewModels.Common;

namespace VietjetAir.Application.Catalog.GroupPermission
{
    public interface IGroupPermissionService
    {
        Task<ResultModel<GroupPermissionViewModel>> GetGroupPermission(PagingRequestBase request);
        /* Task<string> GetMemberPerGroup(int groupId);*/
        Task<List<UserAccountModel>> GetUserAccounts();
        Task<int> AddGroupMember(string GroupName, List<Guid> ListMember);
        Task<int> RemoveGroupMember(string GroupName, List<Guid> ListMember);
        Task<GroupDetailViewModel> GetGroupDetail(string GroupName);
        Task<bool> UpdateGroup(string GroupName, UpdateGroupRequest request);
        Task<bool> CreateGroup(CreateGroupRequest request);
        Task<bool> RemoveGroup(string GroupName);
    }
}
