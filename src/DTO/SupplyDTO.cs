namespace FusionTech.src.DTO
{
    public class SupplyDTO
    {
        public class SupplyCreateDto
        {
            public Guid SupplierId { get; set; }

            [Range(0.01, double.MaxValue, ErrorMessage = "Supplier quantity must be greater than zero.")]
            public float SupplierQuantity { get; set; }
            public DateTime SupplierDate { get; set; }
            public Guid InventoryId { get; set; }
            public Guid VideoGameVersionId { get; set; }
        }

        public class SupplyReadDto
        {
            public Guid SupplyId { get; set; }
            public Guid SupplierId { get; set; }
            public Guid VideoGameVersionId { get; set; }
            public float SupplierQuantity { get; set; }
            public DateTime SupplierDate { get; set; }
            public Guid InventoryId { get; set; }
            public Supplier? Supplier { get; set; }
            public Inventory? Inventory { get; set; }
        }

        public class SupplyUpdateDto
        {
            [Range(0.01, double.MaxValue, ErrorMessage = "Supplier quantity must be greater than zero.")]
            public float SupplierQuantity { get; set; }
            public DateTime SupplierDate { get; set; }
        }
    }
}
