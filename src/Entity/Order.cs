using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FusionTech.src.Entity
{
    public class Order
    {
        public int OrderId { get; set; }

        [Required(ErrorMessage = "Order date is required.")]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        [Required(ErrorMessage = "Total price is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Total price must be greater than zero.")]
        public float TotalPrice { get; set; }
        [ForeignKey("PaymentId")]
        public int PaymentId { get; set; }
        public int StoreId { get; set; }
        public int EmployeeId { get; set; }
        public int CustomerId { get; set; }
    }
}

