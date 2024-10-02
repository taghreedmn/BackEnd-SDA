namespace FusionTech.src.Entity
{
    public class SystemAdmin : Person
    {
        public bool ManageStores { get; private set; }
        public bool ManageEmployees { get; private set; }
        public bool ManageGames { get; private set; }
        public bool ManageCustomers { get; private set; }
        public static new readonly PersonType PersonType = PersonType.SystemAdmin;
    }
}
