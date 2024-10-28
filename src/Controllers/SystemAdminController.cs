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
            var AdminCreated = await _systemAdminService.CreateOneAsync(createDto, userEmail);
            return Ok(AdminCreated);
        }

        [HttpDelete]
        public async Task<ActionResult<bool>> DeletePerson(int personId)
        {
            var adminEmail = User.FindFirst(ClaimTypes.Email)!.Value;
            bool isDeleted;

            isDeleted = await _systemAdminService.DeletePersonAsync(personId, adminEmail);

            return Ok(isDeleted);
        }

        [HttpGet]
        public async Task<ActionResult<List<SystemAdminReadDto>>> GetAllUsers(
            [FromQuery] PaginationOptions paginationOptions
        )
        {
            var users = await _systemAdminService.GetAllAsync(paginationOptions);
            var totalCount = await _systemAdminService.CountSystemAdminsAsync();
            var CustomerListDto = new SystemAdminListDto
            {
                SystemAdmins = users,
                TotalCount = totalCount,
            };
            return Ok(CustomerListDto);
        }

        [HttpGet("Profile")]
        public async Task<ActionResult<SystemAdminReadDto>> GetSystemAdminProfile()
        {
            var authenticateClaims = HttpContext.User;
            var userIdClaim = authenticateClaims.FindFirst(c =>
                c.Type == ClaimTypes.NameIdentifier
            );

            if (userIdClaim == null || !int.TryParse(userIdClaim.Value, out var userId))
            {
                return BadRequest("User ID not found in claims");
            }

            return Ok(await _systemAdminService.GetOneById(userId));
        }
    }
}
