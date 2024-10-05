using System.ComponentModel.DataAnnotations;

namespace FusionTech.src.DTO
{
    public class StoreDTO
    {
        public class StoreCreateDto
        {
            public Guid InventoryId { get; set; }

            [Range(1, int.MaxValue, ErrorMessage = "Number of employees must be at least 1.")]
            public int NumberOfEmployee { get; set; }

            [Range(1, int.MaxValue, ErrorMessage = "Work hours must be at least 1.")]
            public int WorkHours { get; set; }

            [StringLength(200, ErrorMessage = "Location cannot exceed 200 characters.")]
            public string? Location { get; set; }
        }

        public class StoreReadDto
        {
            public Guid StoreId { get; set; }
            public Guid InventoryId { get; set; }
            public Guid EmployeeId { get; set; }
            public int NumberOfEmployee { get; set; }
            public int WorkHours { get; set; }
            public string? Location { get; set; }
        }

        public class StoreUpdateDto
        {
            public Guid StoreId { get; set; }
            public Guid InventoryId { get; set; }

            [Range(1, int.MaxValue, ErrorMessage = "Number of employees must be at least 1.")]
            public int NumberOfEmployee { get; set; }

            [Range(1, int.MaxValue, ErrorMessage = "Work hours must be at least 1.")]
            public int WorkHours { get; set; }

            [StringLength(200, ErrorMessage = "Location cannot exceed 200 characters.")]
            public string? Location { get; set; }
        }
    }
}
