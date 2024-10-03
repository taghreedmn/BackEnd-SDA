using System.ComponentModel.DataAnnotations;

namespace FusionTech.src.DTO
{
    public class StoreEmployeeDTO : PersonDTO
    {
        public class StoreEmployeeSignUpDTO : PersonSignUpDTO
        {
            public string? Role { get; set; }

            [Range(3000, 30000, ErrorMessage = "Salary must be between {1} and {2}.")]
            public float Salary { get; set; }

            [Range(
                0,
                50,
                ErrorMessage = "years cannot be less than 0 or abov ... LET THE GUY REST"
            )]
            public int YearsOfService { get; set; } = 0;
        }

        public class StoreEmployeeSignInDto : PersonSignInDTO
        {
            public string? Role { get; set; }
            public float Salary { get; set; }
            public int YearsOfService { get; set; }
        }
    }
}
