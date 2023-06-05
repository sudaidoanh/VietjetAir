using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
            if(data == null) { return NotFound("Cant get data"); }
            return Ok(data);
        }

        [HttpPut("General")]
        public async Task<IActionResult> ChangeGeneralSetting(string UserUpdate, [FromForm] ChangeGeneralSettingRequest request)
        {
            var result = await _settingService.ChangeGeneralSetting(UserUpdate, request);
            if (result == false) return (BadRequest("No event changed")); 
            return Ok(result);
        }

    }
}
