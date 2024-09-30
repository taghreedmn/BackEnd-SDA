using System.ComponentModel.DataAnnotations;

namespace FusionTech.src.Entity
{
    public class Supply
    {
        public Guid SupplyId { get; set; }
        public Guid SupplierId { get; set; }
        public Guid GamesId { get; set; }

        [Required(ErrorMessage = "Supplier quantity is required.")]
        [Range(0.01, float.MaxValue, ErrorMessage = "Supplier quantity must be greater than zero.")]
        public float SupplierQuantity { get; set; }

        [Required(ErrorMessage = "Supplier date is required.")]
        [DataType(DataType.Date)]
        public DateTime SupplierDate { get; set; }
        public Guid InventoryId { get; set; }
    }
}
