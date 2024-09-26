using Microsoft.AspNetCore.Mvc;
using backend.src.Entity;

namespace backend.src.Controllers
 {
    [ApiController]
    [Route("api/v1/[controller]")]
    public class OrderController : ControllerBase
    {
        private List<Order> Order = new List<Order>
        {
            new Order { OrderId = 1, OrderDate = new DateTime(2020, 12, 12), TotalPrice = 150, PaymentId = 1, StoreId = 1, EmployeeId = 1, CustomerId = 101 },
            new Order { OrderId = 2, OrderDate = new DateTime(2021, 1, 15), TotalPrice = 250, PaymentId = 2, StoreId = 1, EmployeeId = 2, CustomerId = 102 },
            new Order { OrderId = 3, OrderDate = new DateTime(2021, 2, 20), TotalPrice = 350, PaymentId = 3, StoreId = 2, EmployeeId = 1, CustomerId = 103 }
        };

        // Create a new order
        [HttpPost]
        public ActionResult CreateOrder(Order newOrder)
        {
            newOrder.OrderId = Order.Count > 0 ? Order.Max(o => o.OrderId) + 1 : 1;
            Order.Add(newOrder);
            return CreatedAtAction(nameof(GetOrderById), new { id = newOrder.OrderId }, newOrder);
        }

        // Get all orders
        [HttpGet]
        public ActionResult GetAllOrders()
        {
            return Ok(Order);
        }

        // Get a specific order by ID
        [HttpGet("{id}")]
        public ActionResult GetOrderById(int id)
        {
            Order? foundOrder = Order.FirstOrDefault(o => o.OrderId == id);
            if (foundOrder == null)
            {
                return NotFound();
            }
            return Ok(foundOrder);
        }

        // Update an existing order
        [HttpPut("{id}")]
        public ActionResult UpdateOrder(int id, [FromBody] Order updatedOrder)
        {
            var index = Order.FindIndex(o => o.OrderId == id);
            if (index == -1)
            {
                return NotFound();
            }

            updatedOrder.OrderId = id; // Keep the original ID
            Order[index] = updatedOrder;
            return Ok(updatedOrder);
        }

        // Delete an order
        [HttpDelete("{id}")]
        public ActionResult DeleteOrder(int id)
        {
             Order? foundOrder = Order.FirstOrDefault(o => o.OrderId == id);
            if (foundOrder == null)
            {
                return NotFound();
            }
            Order.Remove(foundOrder);
            return NoContent();
        }
    }
}
