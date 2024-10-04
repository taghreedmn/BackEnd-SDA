using System.ComponentModel.DataAnnotations;

namespace FusionTech.src.Entity
{
    public class Order
    {
        public Guid OrderId { get; set; }

        [Required(ErrorMessage = "Order date is required.")]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        public Guid PaymentId { get; set; }
        public Guid StoreId { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid CustomerId { get; set; }
        // public Payment Payment { get; set; }
        // public Store Store { get; set; }
        // public Employee Employee{ get; set; }
        // public Customer Customer { get; set; }
        public List<OrderedGames> OrderedGames { get; set; }

    }
}

