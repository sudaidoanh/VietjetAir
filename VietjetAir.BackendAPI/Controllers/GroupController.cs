using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VietjetAir.ViewModels.Catalog.GroupPermission;
using VietjetAir.ViewModels.Common;

namespace VietjetAir.BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Administrators, Owner")]
    public class GroupController : ControllerBase
    {
        private readonly IGroupPermissionService _groupPermission;
        public GroupController(IGroupPermissionService groupPermission)
        {
            _groupPermission = groupPermission;
        }

        [HttpGet]
        public async Task<IActionResult> GetGroupPermission([FromQuery] PagingRequestBase request)
        {
            var data = await _groupPermission.GetGroupPermission(request);
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }
        [HttpPost]
        public async Task<IActionResult> CreateGroup(CreateGroupRequest request)
        {
            if (request == null) { return BadRequest(); };
            var result = await _groupPermission.CreateGroup(request);
            return Ok(result);
        }

        [HttpGet("{GroupName}")]
        public async Task<IActionResult> GetGroupDetail(string GroupName)
        {
            var data = await _groupPermission.GetGroupDetail(GroupName);
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }

        [HttpPut("{GroupName}")]
        public async Task<IActionResult> UpdateGroup(string GroupName, [FromForm] UpdateGroupRequest request)
        {
            if (GroupName == null) { return BadRequest("Cant get group"); }
            var result = await _groupPermission.UpdateGroup(GroupName, request);
            if(!result) { return BadRequest("Update failed, or field Name empty"); }
            return Ok(result);
        }

        [HttpDelete("{GroupName}")]
        public async Task<IActionResult> RemoveGroup(string GroupName)
        {
            if (GroupName == null) { return BadRequest("Cant get group"); }
            var result = await _groupPermission.RemoveGroup(GroupName);
            if(result == false) { return BadRequest("Cant remove group"); }
            return Ok("Remove group success");
        }
    }
}
