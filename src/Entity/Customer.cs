namespace FusionTech.src.Entity
{
    public class Customer : Person
    {
        public int Age { get; set; }

        public ICollection<RatedBy> RatedBies { get; set; }
        public ICollection<Order> Orders { get; set; }
        public static new readonly PersonType PersonType = PersonType.Customer;
    }
}
