using System.ComponentModel.DataAnnotations;

namespace FusionTech.src.Entity
{
    public class Customer : Person
    {
        [Range(0, 120, ErrorMessage = "Age must be between 0 and 120.")]
        public int Age { get; set; }
        public static readonly PersonType PersonType = PersonType.Customer;
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
    }
}
