namespace FusionTech.src.DTO
{
    public class InventoryDTO
    {
        public class InventoryCreateDto
        {
            public Guid VideoGameVersionId { get; set; }
            public Guid StoreId { get; set; }

            [Required(ErrorMessage = "Inventory quantity is required.")]
            [Range(1, int.MaxValue, ErrorMessage = "Inventory quantity must be greater than zero.")]
            public int GameQuantity { get; set; }
        }

        public class InventoryReadDto
        {
            public Guid VideoGameVersionId { get; set; }

            public Guid StoreId { get; set; }

            public int GameQuantity { get; set; }
        }

        public class InventoryUpdateDTO
        {
            public Guid StoreId { get; set; }
            public Guid VideoGameVersionId { get; set; }

            [Required(ErrorMessage = "Quantity is required.")]
            [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than zero.")]
            public int GameQuantity { get; set; }
        }
    }
}
