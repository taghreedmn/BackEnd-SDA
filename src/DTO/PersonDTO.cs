using System.ComponentModel.DataAnnotations;
using FusionTech.src.Entity;

namespace FusionTech.src.DTO
{
    public class PersonDTO
    {
        public class PersonSignUpDTO
        {
            [StringLength(
                100,
                MinimumLength = 3,
                ErrorMessage = "Name must be between 3 and 100 characters"
            )]
            public required string PersonName { get; set; }

            [EmailAddress(ErrorMessage = "Invalid Email Address")]
            public required string PersonEmail { get; set; }

            [DataType(DataType.Password)]
            [MinLength(8)]
            public required string PersonPassword { get; set; }

            [Phone(ErrorMessage = "Invalid phone number")]
            public string? PersonPhone { get; set; }
            public string? ProfilePicturePath { get; set; }
        }

        public class PersonSignInDTO
        {
            public required string PersonEmail { get; set; }

            public required string PersonPassword { get; set; }
        }

        public class PersonReadDto
        {
            public required string PersonId { get; set; }
            public required string PersonName { get; set; }
        }
    }
}
