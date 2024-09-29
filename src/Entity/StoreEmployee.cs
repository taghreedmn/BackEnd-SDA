namespace FusionTech.src.Entity
{
    public class StoreEmployee : Person
    {
        public string? Role { get; set; }
        public float Salary { get; set; }
        public int YearsOfService { get; set; }
        public static readonly PersonType PersonType = PersonType.StoreEmployee;
    }
}
