using System.ComponentModel.DataAnnotations;

namespace FusionTech.src.Entity
{
    public class Payment
    {
        public Guid PaymentId { get; set; }
        public string? PaymentMethod { get; set; }
    }
}
