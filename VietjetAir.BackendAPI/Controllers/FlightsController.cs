using Azure.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection;
using System.Security.Claims;
using VietjecAir.Data.Entities;
using VietjetAir.Application.Catalog.FlightServices;
using VietjetAir.Application.Systems.Permission;
using VietjetAir.ViewModels.Catalog.FlightServices;

namespace VietjetAir.BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class FlightsController : ControllerBase
    {
        private readonly IFlightService _flightService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IPermissionService _permissionService;
        public FlightsController(UserManager<AppUser> userManager, IPermissionService permissionService, IFlightService flightService)
        {
            _userManager = userManager;
            _permissionService = permissionService;
            _flightService = flightService;
        }

        [HttpPost("Point")]
        public async Task<IActionResult> AddPoint([FromForm] PointModel request)
        {
            var currentUser = HttpContext.User;
            string emailUser = currentUser.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email).Value;

            if (await _permissionService.CheckPermission(emailUser, "Read and modify"))
            {
                var result = await _flightService.AddPoint(request);
                if (result == false) { return BadRequest(result); }
                return Ok(result);
            }
            return StatusCode(403, "Permission Denied");
        }

        [HttpGet("Point")]
        public async Task<IActionResult> GetPoint()
        {
            var data = await _flightService.GetPoint();
            if (data == null) { return BadRequest("Cant get data"); }
            return Ok(data);

        }

        [HttpPost("Document")]
        public async Task<IActionResult> AddFlightDocs([FromForm] AddFlightDocsRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var currentUser = HttpContext.User;
            string emailUser = currentUser.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email).Value;
            var user = await _userManager.FindByEmailAsync(emailUser);

            if (await _permissionService.CheckPermission(emailUser, "Read and modify"))
            {
                var result = await _flightService.AddFlightDocs(user.Email, request);
                if (!result)
                {
                    return BadRequest("Cant add, get Flight infomation or document");
                }
                return Ok(result);
            }
            return StatusCode(403, "Permission Denied");


        }

        [HttpGet("Documents")]
        public async Task<IActionResult> GetAllFlightDocs([FromQuery] GetAllFlightPagingRequest request)
        {
            var data = await _flightService.GetAllFlightDocs(request);
            if (data == null) { return BadRequest("Cant get data"); }

            return Ok(data);
        }

        [HttpGet("Documents/{FlightNo}")]
        public async Task<IActionResult> GetFlightDocDetail(string FlightNo)
        {
            var currentUser = HttpContext.User;
            string emailUser = currentUser.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email).Value;

            if ( await _permissionService.CheckPermissionOnDocsWithFlightNo(emailUser, FlightNo, "Read and modify")
                || await _permissionService.CheckPermissionOnDocsWithFlightNo(emailUser, FlightNo, "Read only")
                )
            {
                var data = await _flightService.GetFlightDocDetail(FlightNo);
                if (data == null) { return BadRequest("Cant get data"); }
                return Ok(data);
            }
            return StatusCode(403, "Permission Denied");
        }

        [HttpPut("Documents/{FlightNo}")]
        public async Task<IActionResult> EditFlightDoc(string FlightNo, GetAllFlightPagingRequest request)
        {
            var currentUser = HttpContext.User;
            string emailUser = currentUser.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email).Value;

            if (await _permissionService.CheckPermissionOnDocsWithFlightNo(emailUser, FlightNo, "Read and modify")
                || await _permissionService.CheckPermissionOnDocsWithFlightNo(emailUser, FlightNo, "Read only")
                )
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var data = await _flightService.GetAllFlightDocs(request);
                if (data == null) { return BadRequest("Cant get data"); }
                return Ok(data);
            }
            return StatusCode(403, "Permission Denied");
        }


        [HttpDelete("Documents/{FlightNo}")]
        public async Task<IActionResult> RemoveFlightDoc(string FlightNo)
        {
            var currentUser = HttpContext.User;
            string emailUser = currentUser.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email).Value;
            var data = await _flightService.GetFlightDocDetail(FlightNo);
            if (data == null) { return BadRequest("Cant get data"); }

            if (await _permissionService.CheckPermissionOnDocsWithFlightNo(emailUser, FlightNo, "Read and modify")
                || await _permissionService.CheckPermissionOnDocsWithFlightNo(emailUser, FlightNo, "Read only")
                )
            {
                return Ok(data);
            }
            return StatusCode(403, "Permission Denied");
        }
    }
}
