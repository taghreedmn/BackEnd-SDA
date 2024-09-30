namespace FusionTech.src.DTO
{
    public class ConsoleDTO
    {
        public class CreateConsoleDTO
        {
            public string ConsoleName { get; set; }
        }

        public class ReadConsoleDTO
        {
            public Guid GameConsoleId { get; set; }
            public string ConsoleName { get; set; }
        }

        public class UpdateConsoleDTO
        {
            public Guid GameConsoleId { get; set; }
            public string ConsoleName { get; set; }
        }
    }
}
