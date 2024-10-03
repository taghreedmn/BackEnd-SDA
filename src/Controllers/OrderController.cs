/* using FusionTech.src.Entity;
using Microsoft.AspNetCore.Mvc;


namespace FusionTech.src.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class OrderController : ControllerBase
    {
        // Create a new order
        [HttpPost]
        public ActionResult CreateOrder(Order newOrder)
        {
            throw new NotImplementedException();
        }

        // Get all orders
        [HttpGet]
        public ActionResult GetAllOrders()
        {
            throw new NotImplementedException();
        }

        // Get a specific order by ID
        [HttpGet("{id}")]
        public ActionResult GetOrderById(Guid id)
        {

            throw new NotImplementedException();

            Order? foundOrder = Order.FirstOrDefault(o => o.OrderId += id);
            if (foundOrder == null)
            {
                return NotFound();
            }
            return Ok(foundOrder);

        }

        // Update an existing order
        [HttpPut("{id}")]
        public ActionResult UpdateOrder(Guid id, [FromBody] Order updatedOrder)
        {
            throw new NotImplementedException();
        }

        // Delete an order
        [HttpDelete("{id}")]
        public ActionResult DeleteOrder(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
  */