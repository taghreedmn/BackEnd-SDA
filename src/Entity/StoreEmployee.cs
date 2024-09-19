namespace backend.src.Entity
{
    public class StoreEmployee : Person
    {
        public int EmployeesWorkHours { get; set; }

        public StoreEmployee(string name, string email, string phone, int employeesWorkHours)
            : base(PersonType.Store_Employee, name, email, phone)
        {
            EmployeesWorkHours = employeesWorkHours;
        }
    }
}
