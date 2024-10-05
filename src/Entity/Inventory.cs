

using System.ComponentModel.DataAnnotations.Schema;

namespace FusionTech.src.Entity
{
    public class Inventory
    {
        public Guid InventoryId { get; set; }

        [ForeignKey("ViedoGameVersion")]
        public Guid VideoGameVersionId { get; set; }
        public Guid StoreId { get; set; }
        public int GameQuantity { get; set; }
    }
}