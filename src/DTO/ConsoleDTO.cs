namespace sda_3_online_Backend_Teamwork.src.DTO
{
    public class ConsoleDTO
    {
        public class CreatConsoleDTO 
        {
            public string ConsoleName { get; set; }
        }

        public class ReadConsoleDTO
        {
            public Guid ConsoleId { get; set; }
            public string ConsoleName { get; set; }
        }

        public class UpdateConsoleDTO
        {
            public Guid ConsoleId { get; set; }
            public string ConsoleName { get; set; }
        }
    }
}
