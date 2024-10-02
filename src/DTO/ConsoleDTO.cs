using System.ComponentModel.DataAnnotations;

namespace FusionTech.src.DTO
{
    public class ConsoleDTO
    {
        public class CreateConsoleDTO
        {
            [StringLength(15)]
            [RegularExpression(
                @"^[a-zA-Z\d\s]+$",
                ErrorMessage = "Console name can only contain letters, digits, and spaces."
            )]
            public required string ConsoleName { get; set; }
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
