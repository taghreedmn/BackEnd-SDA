using System.Security.Claims;
using FusionTech.src.Services.StoreEmployee;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static FusionTech.src.DTO.StoreEmployeeDTO;

namespace FusionTech.src.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class StoreEmployeeController : ControllerBase
    {
        protected readonly IStoreEmployeeService _storeEmployeeService;

        public StoreEmployeeController(IStoreEmployeeService storeEmployeeService)
        {
            _storeEmployeeService = storeEmployeeService;
        }

        [Authorize(Policy = "admin")]
        [HttpPost]
        public async Task<ActionResult<StoreEmployeeSignInDto>> SignUpEmployee(
            StoreEmployeeSignUpDTO createDto
        )
        {
            var adminEmail = User.FindFirst(ClaimTypes.Email)!.Value;
            try
            {
                var createdEmployee = await _storeEmployeeService.CreateOneAsync(
                    createDto,
                    adminEmail
                );
                return Ok(createdEmployee);
            }
            catch (UnauthorizedAccessException e)
            {
                return Unauthorized(e.Message);
            }
        }
    }
}
