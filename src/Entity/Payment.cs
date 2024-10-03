using System.ComponentModel.DataAnnotations;

namespace FusionTech.src.Entity
{
    public class Payment
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Payment method is required.")]
        [StringLength(30, ErrorMessage = "Payment method cannot exceed 30 characters.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Payment method can only contain letters and spaces.")]
        public string PaymentMethod { get; set; }
    }
}
