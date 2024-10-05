using System.ComponentModel.DataAnnotations;

namespace FusionTech.src.DTO
{
    public class InventoryDTO
    {
        public class InventoryCreateDto
        {
            public Guid GameId { get; set; }
            public Guid StoreId { get; set; }

            [Required(ErrorMessage = "Inventory quantity is required.")]
            [Range(1, int.MaxValue, ErrorMessage = "Inventory quantity must be greater than zero.")]
            public int GameQuantity { get; set; }
        }

        public class InventoryReadDto
        {
            public Guid InventoryId { get; set; }

            public Guid GameId { get; set; }

            public Guid StoreId { get; set; }

            public int GameQuantity { get; set; }
        }

        public class InventoryModifyGameQuantityDTO
        {
            public Guid InventoryId { get; set; }
            public Guid GameId { get; set; }

            [Required(ErrorMessage = "Quantity is required.")]
            [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than zero.")]
            public int GameQuantity { get; set; }
        }
    }
}
