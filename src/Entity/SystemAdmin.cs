namespace FusionTech.src.Entity
{
    public class SystemAdmin : Person
    {
        public bool ManageStores { get; private set; }
        public bool ManageEmployess { get; private set; }
        public bool ManageGames { get; private set; }
        public bool ManageCustomers { get; private set; }

        public SystemAdmin(
            string name,
            string email,
            string password,
            string phone,
            string profilePicturePath,
            bool manageStores,
            bool manageEmployess,
            bool manageGames,
            bool manageCustomers
        )
            : base(PersonType.System_Admin, name, email, password, phone, profilePicturePath)
        {
            ManageStores = manageStores;
            ManageEmployess = manageEmployess;
            ManageGames = manageGames;
            ManageCustomers = manageCustomers;
        }
    }
}
