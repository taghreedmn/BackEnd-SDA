namespace FusionTech.src.Entity
{
    public class Store
    {
        public Guid StoreId { get; set; }
        public int WorkHours { get; set; } // We could change this to make more meaningful
        public string Location { get; set; }
        public ICollection<StoreEmployee> storeEmployees { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Inventory> Inventories { get; set; }
    }
}
