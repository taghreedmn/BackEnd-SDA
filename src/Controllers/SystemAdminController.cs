using System.Security.Claims;
using FusionTech.src.Services.SystemAdmin;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static FusionTech.src.DTO.SystemAdminDTO;

namespace FusionTech.src.Controllers
{
    [Authorize(Policy = "admin")]
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SystemAdminController : ControllerBase
    {
        protected readonly ISystemAdminService _systemAdminService;

        public SystemAdminController(ISystemAdminService systemAdminService)
        {
            _systemAdminService = systemAdminService;
        }

        [HttpPost]
        public async Task<ActionResult<SystemAdminReadDto>> SignUp(SystemAdminSignUpDTO createDto)
        {
            var userEmail = User.FindFirst(ClaimTypes.Email)!.Value;
            try
            {
                var AdminCreated = await _systemAdminService.CreateOneAsync(createDto, userEmail);
                return Ok(AdminCreated);
            }
            catch (UnauthorizedAccessException e)
            {
                return Unauthorized(e.Message);
            }
        }
    }
}
