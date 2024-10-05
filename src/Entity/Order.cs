using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FusionTech.src.Entity
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderedGames> OrderedGames { get; set; }
        public float TotalPrice { get; set; }
        [ForeignKey("PaymentId")]
        public int PaymentId { get; set; }
        public int StoreId { get; set; }
        public int EmployeeId { get; set; }
        public int CustomerId { get; set; }
    }
}
