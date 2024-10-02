using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FusionTech.src.DTO
{
    public class InventoryDTO
    {
        public class InventoryCreateDto
        {
            public Guid GameId { get; set; }
            public Guid StoreId { get; set; }
            public int InventoryQuantity { get; set; }
        }

        public class InventoryReadDto
        {
            public Guid InventoryId { get; set; }
            public Guid GameId { get; set; }
            public Guid StoreId { get; set; }
            public int InventoryQuantity { get; set; }
        }

       

        public class InventoryModifyGameQuantityDTO
        {
            public Guid InventoryId { get; set; }
            public Guid GameId { get; set; }
            public int Quantity { get; set; }  
        }
    }
}
