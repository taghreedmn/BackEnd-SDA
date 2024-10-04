using System.ComponentModel.DataAnnotations;

namespace FusionTech.src.DTO
{
    public class PaymentDTO
    {
        public class PaymentCreateDto
        {
            [Required(ErrorMessage = "Payment method is required.")]
            [StringLength(50, ErrorMessage = "Payment method cannot exceed 50 characters.")]
            public string? PaymentMethod { get; set; }
        }

        public class PaymentReadDto
        {
            public Guid PaymentId { get; set; }
            public string? PaymentMethod { get; set; }
        }

        public class PaymentUpdateDto
        {
            [StringLength(50, ErrorMessage = "Payment method cannot exceed 50 characters.")]
            public string? PaymentMethod { get; set; }
        }
    }
}

