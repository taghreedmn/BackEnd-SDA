namespace FusionTech.src.Entity
{
    public class SystemAdmin : Person
    {
        public bool ManageStores { get; set; }
        public bool ManageEmployees { get; set; }
        public bool ManageGames { get; set; }
        public bool ManageCustomers { get; set; }
        public bool ManageSystemAdmins { get; set; }
        public static new readonly PersonType PersonType = PersonType.SystemAdmin;
    }
}
