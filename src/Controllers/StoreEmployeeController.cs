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
        public async Task<ActionResult<StoreEmployeeSignUpDTO>> SignUpEmployee(
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

        [HttpGet]
        [Authorize(Policy = "admin")]
        public async Task<ActionResult<List<StoreEmployeeReadDto>>> GetAllUsers(
            [FromQuery] PaginationOptions paginationOptions
        )
        {
            var users = await _storeEmployeeService.GetAllAsync(paginationOptions);
            var totalCount = await _storeEmployeeService.CountStoreEmployeesAsync();
            var CustomerListDto = new StoreEmployeeListDto
            {
                StoreEmployees = users,
                TotalCount = totalCount,
            };
            return Ok(CustomerListDto);
        }
    }
}
