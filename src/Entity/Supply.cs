
using System.ComponentModel.DataAnnotations;

namespace FusionTech.src.Entity
{
    public class Supply
    {
        public Guid SupplyId { get; set; }
        public Guid SupplierId { get; set; }
        public Guid VideoGameVersionId { get; set; }
        public Guid InventoryId { get; set; }
        public float SupplyQuantity { get; set; }
        public DateTime SupplierDate { get; set; }
        public Supplier? Supplier { get; set; }
        public Inventory? Inventory { get; set; }
        public VideoGameVersion? VideoGameVersion { get; set; }
        public Guid GamesId { get; internal set; }
    }
}
