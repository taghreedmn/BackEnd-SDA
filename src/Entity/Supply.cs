
using System.ComponentModel.DataAnnotations;

namespace FusionTech.src.Entity
{
    public class Supply
    {
        public Guid SupplyId { get; set; }
        public Guid SupplierId { get; set; }
        public Guid GamesId { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        [Range(0.01, float.MaxValue, ErrorMessage = "Quantity must be greater than zero")]
        public float SupplierQuantity { get; set; }

        [Required(ErrorMessage = "Date is required")]
        public DateTime SupplierDate { get; set; }
        public Guid InventoryId { get; set; }
    }
}
