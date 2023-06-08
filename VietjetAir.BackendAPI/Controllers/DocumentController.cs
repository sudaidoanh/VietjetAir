using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using VietjecAir.Data.Entities;
using VietjetAir.Application.Catalog.DocumentType;
using VietjetAir.ViewModels.Catalog.Configuration;
using VietjetAir.ViewModels.Catalog.GroupPermission;

namespace VietjetAir.BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DocumentController : ControllerBase
    {
        private readonly IDocumentTypeService _documentTypeService;
        private readonly UserManager<AppUser> _userManager;

        public DocumentController(UserManager<AppUser> userManager, IDocumentTypeService documentTypeService)
        {
            _userManager = userManager;
            _documentTypeService = documentTypeService;
        }

        [HttpGet("Configuration")]
        public async Task<IActionResult> GetDocumentTypeAsync([FromQuery] GetDocumentTypeRequest request)
        {
            var data = await _documentTypeService.GetDocumentTypeAsync(request);
            if (data == null) { return NotFound(); }
            return Ok(data);
        }

        [HttpPost("Configuration")]
        [Authorize(Roles = "Owner, Administrator")]
        public async Task<IActionResult> AddDocumentTypeAsync([FromBody] AddDocumentTypeRequest request)
        {

            var currentUser = HttpContext.User;
            string emailUser = currentUser.Claims.FirstOrDefault(c => c.Type.Equals("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress")).Value;
            var user = await _userManager.FindByEmailAsync(emailUser);
            var result = await _documentTypeService.AddDocumentTypeAsync(user.Id, request);

            return Ok(result);
        }

        [HttpPut("Configuration/{DocTypeName}")]
        [Authorize(Roles = "Owner, Administrator")]
        public async Task<IActionResult> UpdatedDocumentTypeAsync(string DocTypeName, [FromForm] UpdateDocTypeRequest request)
        {
            if (DocTypeName == null) { return BadRequest("Cant get Document Type Page"); }
            var result = await _documentTypeService.UpdatedDocumentTypeAsync(DocTypeName, request);
            if (!result) { return BadRequest("Update failed, or field Name empty"); }
            return Ok(result);
        }

        [HttpDelete("Configuration/{DocTypeName}")]
        [Authorize(Roles = "Owner, Administrator")]
        public async Task<IActionResult> RemovedDocumentTypeAsync(string DocTypeName)
        {
            if (DocTypeName == null) { return BadRequest("Cant get Document Type Page"); }
            var result = await _documentTypeService.RemovedDocumentTypeAsync(DocTypeName);
            if (result == false) { return BadRequest("Cant Document Type"); }
            return Ok("Remove Document Type success");
        }

        [HttpGet("Configuration/{DocTypeName}")]
        [Authorize(Roles = "Owner, Administrator")]
        public async Task<IActionResult> GetDocTypeDetailAsync(string DocTypeName)
        {
            var data = await _documentTypeService.GetDocTypeDetailAsync(DocTypeName);
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }

        [HttpPost("Configuration/{DocTypeName}")]
        [Authorize(Roles = "Owner, Administrator")]
        public async Task<IActionResult> AdddDocTypePermissionAsync(string DocTypeName, [FromForm] AddPermissionRequest request)
        {
            var result = await _documentTypeService.AdddDocTypePermissionAsync(DocTypeName, request);
            if (result == 0) { return BadRequest("Cant add permission to this document type cause permission is not valid"); }
            return Ok(result);
        }

        [HttpDelete("Configuration/{DocTypeName}/RemovePermission")]
        [Authorize(Roles = "Owner, Administrator")]
        public async Task<IActionResult> RemoveDocTypePermissionAsync(string DocTypeName, [FromBody] int GroupId)
        {
            var result = await _documentTypeService.RemoveDocTypePermissionAsync(DocTypeName, GroupId);
            if (result == 0) { return BadRequest("Cant excute action to this page cause permission is not valid"); }
            return Ok(result);
        }


    }
}
