using System.ComponentModel.DataAnnotations;

namespace FusionTech.src.Entity
{
    public class GameConsole
    {
        public Guid GameConsoleId { get; set; }

        [Required(ErrorMessage = "Console name is required.")]
        [StringLength(15, ErrorMessage = "Console name cannot exceed 15 characters.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Console name can only contain letters and spaces.")]
        public string ConsoleName { get; set; }
    }
}
