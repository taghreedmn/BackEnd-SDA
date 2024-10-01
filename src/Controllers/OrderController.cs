using FusionTech.src.Entity;
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
        public ActionResult GetOrderById(int id)
        {
            throw new NotImplementedException();
        }

        // Update an existing order
        [HttpPut("{id}")]
        public ActionResult UpdateOrder(int id, [FromBody] Order updatedOrder)
        {
            throw new NotImplementedException();
        }

        // Delete an order
        [HttpDelete("{id}")]
        public ActionResult DeleteOrder(int id)
        {
            throw new NotImplementedException();
        }
    }
}
