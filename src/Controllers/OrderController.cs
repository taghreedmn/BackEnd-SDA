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
        [Authorize]
        public async Task<ActionResult<OrderReadDto>> CreateOneAsync([FromBody] OrderCreateDto orderCreateDto)
        {
            var authenticateClaims = HttpContext.User;
            var userId = authenticateClaims.FindFirst(c => c.Type == ClaimTypes.NameIdentifier)!.Value;
            var userGuid = new Guid(userId);
            return await _orderService.CreateOneAsync(userGuid, orderCreateDto);
        }

        // Get all orders
        // [HttpGet]
        // public ActionResult GetAllOrders()
        // {

        // }

        // // Get a specific order by ID
        // [HttpGet("{id}")]
        // public ActionResult GetOrderById(int id)
        // {

        // }
        // // Update an existing order
        // [HttpPut("{id}")]
        // public ActionResult UpdateOrder(int id, [FromBody] Order updatedOrder)
        // {

        // }

    }
}
  