namespace FusionTech.src.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class OrderController : ControllerBase
    {
        protected readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        // Create a new order
        [Authorize(Policy = "Customer")]
        [HttpPost]
        public async Task<ActionResult<OrderReadDto>> CreateOneAsync(
            [FromBody] OrderCreateDto orderCreateDto
        )
        {
            var authenticateClaims = HttpContext.User;
            var userIdClaim = authenticateClaims.FindFirst(c =>
                c.Type == ClaimTypes.NameIdentifier
            );

            if (userIdClaim == null || !int.TryParse(userIdClaim.Value, out var userId))
            {
                return BadRequest("User ID not found in claims or is not a valid integer.");
            }

            return await _orderService.CreateOneAsync(userId, orderCreateDto);
        }

        // Get all orders
        [Authorize(Policy = "Customer")]
        [HttpGet]
        public async Task<ActionResult<List<OrderReadDto>>> GetOrderByIdAsync()
        {
            var authenticateClaims = HttpContext.User;
            var userIdClaim = authenticateClaims.FindFirst(c =>
                c.Type == ClaimTypes.NameIdentifier
            );

            if (userIdClaim == null || !int.TryParse(userIdClaim.Value, out var userId))
            {
                return BadRequest("User ID not found in claims or is not a valid integer.");
            }
            var orders = await _orderService.GetOrderByIdAsync(userId);
            if (orders == null || !orders.Any())
            {
                throw CustomException.Forbidden("Forbidden. You do not have access rights to view this content.");
            }

            return Ok(orders);
        }
    }
}
