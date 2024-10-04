using System.Security.Claims;
using FusionTech.src.Entity;
using FusionTech.src.Services.order;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static FusionTech.src.DTO.OrderDTO;

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
        [HttpPost]
        [Authorize(Policy = "Customer")]
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

            // var userGuid = ConvertIntToGuid(userId); //  using int to Guid conversion

            // return await _orderService.CreateOneAsync(userGuid, orderCreateDto);
            return await _orderService.CreateOneAsync(userId, orderCreateDto);
        }

        private Guid ConvertIntToGuid(int customerId)
        {
            byte[] guidBytes = new byte[16];
            BitConverter.GetBytes(customerId).CopyTo(guidBytes, 0);

            // Set the rest of the bytes to zero or handle as needed
            for (int i = 4; i < guidBytes.Length; i++)
            {
                guidBytes[i] = 0;
            }

            return new Guid(guidBytes);
        }

        // Get all orders
        [HttpGet("Customer/{CustomerId}")]
        [Authorize]
        public async Task<ActionResult<List<OrderReadDto>>> GetOrderByIdAsync([FromRoute]int CustomerId)
        {
            var orders = await _orderService.GetOrderByIdAsync(CustomerId);
            return Ok(orders);
        }
        // public async Task<ActionResult<List<OrderReadDto>>> GetAllOrdersAsync()
        // {
        //     var storeList = await _orderService.GetAllOrdersAsync();
        //     return Ok(storeList);
        // }

        // // Get a specific order by ID
        // [HttpGet("{id}")]

        // // Update an existing order
        // [HttpPut("{id}")]
        // public ActionResult UpdateOrder(int id, [FromBody] Order updatedOrder)
        // {

        // }
    }
}
