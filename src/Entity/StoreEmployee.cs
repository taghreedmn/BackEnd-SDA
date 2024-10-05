namespace FusionTech.src.Entity
{
    public class StoreEmployee : Person
    {
        public required string Role { get; set; }
        public float Salary { get; set; }
        public int YearsOfService { get; set; }
        public Guid StoreId { get; set; }
        public ICollection<Order> Orders { get; set; }
        public static new readonly PersonType PersonType = PersonType.StoreEmployee;
    }
}
