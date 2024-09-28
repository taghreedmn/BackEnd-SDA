
namespace FusionTech.src.Entity
{
    public class Supply
    {
        public Guid SupplyId { get; set; } 
        public Guid SupplierId { get; set; }
        public Guid GamesId { get; set; }
        public float SupplierQuantity { get; set; }
        public DateTime SupplierDate { get; set; }
        public Guid InventoryId { get; set; }
    }
}
