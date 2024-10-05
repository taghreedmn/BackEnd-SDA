using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FusionTech.src.Entity
{
    public class Store
    {
        public Guid StoreId { get; set; }
        public int WorkHours { get; set; }
        public string Location { get; set; }
        public ICollection<StoreEmployee> storeEmployees { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}