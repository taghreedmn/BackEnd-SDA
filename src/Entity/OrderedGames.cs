using System.ComponentModel.DataAnnotations;

namespace FusionTech.src.Entity
{
    public class OrderedGames
    {
        public Guid OrderId { get; set; }
        public Guid VideoGameID { get; set; }
        public int OrderQuantity { get; set; }
    }
}