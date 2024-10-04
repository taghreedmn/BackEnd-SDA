using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FusionTech.src.Entity
{
    public class OrderedGames
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("Order")]
        public Guid OrderId { get; set; }
        // [ForeignKey("VideoGameVersion")]
        public Guid VideoGameVersionID { get; set; }

        [Required(ErrorMessage = "Order quantity is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Order quantity must be at least 1.")]
        public int Quantity { get; set; }
        public VideoGameVersion VideoGameVersion{ get; set; }
        
    }
}