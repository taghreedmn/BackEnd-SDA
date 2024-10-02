using System.ComponentModel.DataAnnotations;

namespace FusionTech.src.Entity
{
    public class OrderedGames
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid videoGameID { get; set; }

        [Required(ErrorMessage = "Order quantity is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Order quantity must be at least 1.")]
        public int OrderQuantity { get; set; }
    }
}