namespace FusionTech.src.DTO
{
    public class SystemAdminDTO : PersonDTO
    {
        public class SystemAdminCreateDto : PersonCreateDto
        {
            public bool ManageStores { get; private set; } = false;
            public bool ManageEmployees { get; private set; } = false;
            public bool ManageGames { get; private set; } = false;
            public bool ManageCustomers { get; private set; } = false;
        }

        public class SystemAdminReadDto : PersonSignInDTO
        {
            public bool ManageStores { get; private set; }
            public bool ManageEmployees { get; private set; }
            public bool ManageGames { get; private set; }
            public bool ManageCustomers { get; private set; }
        }
    }
}
