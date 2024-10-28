namespace FusionTech.src.DTO
{
    public class ConsoleDTO
    {
        public class ConsoleCreateDto
        {
            [Required(ErrorMessage = "Console name is required.")]
            [StringLength(100, ErrorMessage = "Console name cannot exceed 100 characters.")]
            public required string ConsoleName { get; set; }
        }

        public class ConsoleReadDTO
        {
            public Guid GameConsoleId { get; set; }
            public string? ConsoleName { get; set; }
        }

        public class ConsoleUpdateDTO
        {
            public Guid GameConsoleId { get; set; }

            [StringLength(100, ErrorMessage = "Console name cannot exceed 100 characters.")]
            public string? ConsoleName { get; set; }
        }
    }
}

