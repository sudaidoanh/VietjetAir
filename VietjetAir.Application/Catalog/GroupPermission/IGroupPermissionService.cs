using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VietjetAir.ViewModels.Common;

namespace VietjetAir.ViewModels.Catalog.GroupPermission
{
    public interface IGroupPermissionService
    {
        Task<ResultModel<GroupPermissionViewModel>> GetGroupPermission(PagingRequestBase request);
        /* Task<string> GetMemberPerGroup(int groupId);*/
        Task<GroupDetailViewModel> GetGroupDetail(string GroupName);
        Task<bool> UpdateGroup(string GroupName, UpdateGroupRequest request);
        Task<bool> CreateGroup(CreateGroupRequest request);
        Task<bool> RemoveGroup(string GroupName);
    }
}
