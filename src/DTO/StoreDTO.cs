using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FusionTech.src.DTO
{
    public class StoreDTO
    {
        public class StoreCreateDto
        {
            public Guid InventoryId { get; set; }
            public int NumberOfEmployee { get; set; }
            public int WorkHours { get; set; }
            public string Location { get; set; }
        }

        public class StoreReadDto
        {
            public Guid StoreId { get; set; }
            public Guid InventoryId { get; set; }
            public int NumberOfEmployee { get; set; }
            public int WorkHours { get; set; }
            public string? Location { get; set; }
        }

        public class StoreUpdateDto
        {
            public Guid StoreId { get; set; }
            public Guid InventoryId { get; set; }
            public int NumberOfEmployee { get; set; }
            public int WorkHours { get; set; }
            public string Location { get; set; }
        }
    }
}