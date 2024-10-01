using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FusionTech.src.Entity
{
    public class Store
    {
        public Guid StoreId { get; set; }
        public Guid InventoryId { get; set; }
        public int NumberOfEmployee { get; set; }
        public int WorkHours { get; set; }
        public Guid EmployeeId { get; set; }
        public string Location { get; set; }
    }
}