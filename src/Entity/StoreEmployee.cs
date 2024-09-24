namespace FusionTech.src.Entity
{
    public class StoreEmployee : Person
    {
        public string Role { get; set; }
        public float Salary { get; set; }
        public int YearsOfService { get; set; }

        public StoreEmployee(
            string name,
            string email,
            string password,
            string phone,
            string profilePicturePath,
            string role,
            float salary,
            int yearsOfService
        )
            : base(PersonType.Store_Employee, name, email, password, phone, profilePicturePath)
        {
            Role = role;
            Salary = salary;
            YearsOfService = yearsOfService;
        }
    }
}
