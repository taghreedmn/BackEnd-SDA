using System.ComponentModel.DataAnnotations;

namespace FusionTech.src.DTO
{
    public class CustomerDTO : PersonDTO
    {
        public class CustomerSignUpDTO : PersonSignUpDTO
        {
            [Range(0, 120, ErrorMessage = "Age must be between 0 and 120.")]
            public int Age { get; set; }
        }

        public class CustomerReadDto : PersonReadDto
        {
            public int Age { get; set; }
        }
    }
}
