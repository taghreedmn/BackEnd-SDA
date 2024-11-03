namespace FusionTech.src.DTO
{
    public class StoreDTO
    {
        public class StoreCreateDto
        {
            [Range(1, int.MaxValue, ErrorMessage = "Work hours must be at least 1.")]
            public int WorkHours { get; set; }

            [StringLength(200, ErrorMessage = "Location cannot exceed 200 characters.")]
            public string? Location { get; set; }
        }

        public class StoreReadDto
        {
            public Guid StoreId { get; set; }
            public int WorkHours { get; set; }
            public string? Location { get; set; }
        }

        public class StoreDetailedReadDto
        {
            public Guid StoreId { get; set; }
            public int WorkHours { get; set; }
            public string? Location { get; set; }
            public ICollection<StoreEmployeeReadDto> storeEmployees { get; set; }
            public ICollection<OrderReadDto> Orders { get; set; }
            public ICollection<InventoryReadDto> Inventories { get; set; }
        }

        public class StoreUpdateDto
        {
            public Guid StoreId { get; set; }

            [Range(1, int.MaxValue, ErrorMessage = "Work hours must be at least 1.")]
            public int WorkHours { get; set; }

            [StringLength(200, ErrorMessage = "Location cannot exceed 200 characters.")]
            public string? Location { get; set; }
        }
    }
}
