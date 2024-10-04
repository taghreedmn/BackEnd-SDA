using System.ComponentModel.DataAnnotations;

namespace FusionTech.src.Entity
{
    public class OrderedGames
    {
        public Guid OrderId { get; set; }
        public Guid VideoGameVersionId { get; set; }

        [Required(ErrorMessage = "Order quantity is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Order quantity must be at least 1.")]
        public int OrderQuantity { get; set; }
    }
}