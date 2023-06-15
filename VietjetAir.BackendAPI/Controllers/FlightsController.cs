using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using VietjecAir.Data.Entities;
using VietjetAir.Application.Catalog.FlightServices;
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
        public FlightsController(UserManager<AppUser> userManager, IFlightService flightService)
        {
            _userManager = userManager;
            _flightService = flightService;
        }

        [HttpPost("Point")]
        public async Task<IActionResult> AddPoint([FromForm] PointModel request)
        {
            var result = await _flightService.AddPoint(request);
            if (result == false) { return BadRequest(result); }
            return Ok(result);
        }

        [HttpGet("Point")]
        public async Task<IActionResult> AddPoint()
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
            string emailUser = currentUser.Claims.FirstOrDefault(c => c.Type.Equals("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress")).Value;
            var user = await _userManager.FindByEmailAsync(emailUser);
            var result = await _flightService.AddFlightDocs(user.Email, request);
            if (!result)
            {
                return BadRequest("Cant add, get Flight infomation or document");
            }
            return Ok(result);
        }

        [HttpGet("Documents")]
        public async Task<IActionResult> GetAllFlightDocs([FromQuery] GetAllFlightPagingRequest request)
        {
            var data = await _flightService.GetAllFlightDocs(request);
            if (data == null) { return BadRequest("Cant get data"); }
            return Ok(data);
        }

        [HttpGet("Documents/{FlightNo}")]
        public async Task<IActionResult> GetAllFlightDocs(string FlightNo, GetAllFlightPagingRequest request)
        {
            var data = await _flightService.GetAllFlightDocs(request);
            if (data == null) { return BadRequest("Cant get data"); }
            return Ok(data);
        }

        [HttpPut("Documents/{FlightNo}")]
        public async Task<IActionResult> EditFlightDoc(string FlightNo, GetAllFlightPagingRequest request)
        {
            var data = await _flightService.GetAllFlightDocs(request);
            if (data == null) { return BadRequest("Cant get data"); }
            return Ok(data);
        }


        [HttpDelete("Documents/{FlightNo}")]
        public async Task<IActionResult> RemoveFlightDoc(string FlightNo, GetAllFlightPagingRequest request)
        {
            var data = await _flightService.GetAllFlightDocs(request);
            if (data == null) { return BadRequest("Cant get data"); }
            return Ok(data);
        }
    }
}
