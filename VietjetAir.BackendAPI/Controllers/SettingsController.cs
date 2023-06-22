using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using VietjetAir.Application.Systems.Settings;
using VietjetAir.ViewModels.Systems.Settings;

namespace VietjetAir.BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Administrators, Owner")]
    public class SettingsController : ControllerBase
    {
        private readonly ISettingService _settingService;
        public SettingsController(ISettingService settingService)
        {
            _settingService = settingService;
        }

        [HttpGet("General")]
        public async Task<IActionResult> GetGeneral()
        {
            var data = await _settingService.GetGeneralSetting();
            if (data == null) { return NotFound("Cant get data"); }
            return Ok(data);
        }

        [HttpPut("General")]
        public async Task<IActionResult> ChangeGeneralSetting(string UserUpdate, [FromForm] ChangeGeneralSettingRequest request)
        {
            var result = await _settingService.ChangeGeneralSetting(UserUpdate, request);
            if (result == false) return (BadRequest("No event changed"));
            return Ok(result);
        }

        [HttpGet("Accounts")]
        public async Task<IActionResult> GetAccountsAsync([FromQuery] GetAccountSettingsRequest request)
        {
            var data = await _settingService.GetAccountPagingAsync(request);
            if (data == null) { return NotFound("Cant get data"); }
            return Ok(data);
        }

        [HttpPatch("Accounts")]
        [Authorize(Roles = "Owner")]
        public async Task<IActionResult> ChangingOwnerAccount([FromForm] ChangingOwnerAccountRequest request)
        {
            var currentUser = HttpContext.User;
            string emailUser = currentUser.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Email).Value;

            var result = await _settingService.ChanggingOwnerAccount(emailUser, request);
            if (result == false) { return BadRequest("Not found user account or owner password wrong!"); }
            return Ok(result);
        }

        [HttpDelete("TerminateUserSession")]
        public async Task<IActionResult> TerminateUserSession([FromBody] List<string> users)
        {
            var result = await _settingService.TerminateUserSession(users);
            if(result == 0 ) { return BadRequest(); }
            return Ok(result);
        }

        [HttpGet("Accounts/{guid}")]
        public async Task<IActionResult> GetAccountDetail([FromQuery] Guid guid)
        {
            var data = await _settingService.GetAccountDetail(guid);
            if (data == null) { return NotFound("Cant get data"); }
            return Ok(data);
        }

        [HttpPatch("Accounts/{guid}")]
        public async Task<IActionResult> UpdateUserAccount([FromQuery] Guid guid)
        {
            var result = await _settingService.GetAccountDetail(guid);
            if (result == null) { return NotFound("Cant get data"); }
            return Ok(result);
        }

        [HttpDelete("Accounts/{guid}")]
        public async Task<IActionResult> RemoveUserAccount([FromQuery] Guid guid)
        {
            var result = await _settingService.GetAccountDetail(guid);
            if (result == null) { return NotFound("Cant get data"); }
            return Ok(result);
        }

        [HttpPatch("Accounts/{guid}/Password")]
        public async Task<IActionResult> ResetPasswordUserAccount([FromQuery] Guid guid)
        {
            var result = await _settingService.GetAccountDetail(guid);
            if (result == null) { return NotFound("Cant get data"); }
            return Ok(result);
        }
    }
}
