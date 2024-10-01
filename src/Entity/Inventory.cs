

namespace FusionTech.src.Entity
{
    public class Inventory
    {
        public Guid InventoryId { get; set; }
        public Guid GameId { get; set; }
        public Guid StoreId { get; set; }
        public int InventoryQuantity { get; set; }
    }
}