namespace FusionTech.src.DTO
{
    public class ConsoleDTO
    {
        public class CreateConsoleDTO
        {
            [Required(ErrorMessage = "Console name is required.")]
            [StringLength(100, ErrorMessage = "Console name cannot exceed 100 characters.")]
            public required string ConsoleName { get; set; }
        }

        public class ReadConsoleDTO
        {
            public Guid GameConsoleId { get; set; }
            public string? ConsoleName { get; set; }
        }

        public class UpdateConsoleDTO
        {
            public Guid GameConsoleId { get; set; }

            [StringLength(100, ErrorMessage = "Console name cannot exceed 100 characters.")]
            public string? ConsoleName { get; set; }
        }
    }
}

