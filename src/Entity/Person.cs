using System.ComponentModel.DataAnnotations;

namespace FusionTech.src.Entity
{
    public abstract class Person
    {
        public int PersonId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(
            100,
            MinimumLength = 3,
            ErrorMessage = "Name must be between 3 and 100 characters"
        )]
        public string? PersonName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string? PersonEmail { get; set; }

        public string? PersonPassword { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage = "Invalid phone number")]
        public string? PersonPhone { get; set; }

        public string? ProfilePicturePath { get; set; }
    }
}
