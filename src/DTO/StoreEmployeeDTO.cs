namespace FusionTech.src.DTO
{
    public class StoreEmployeeDTO : PersonDTO
    {
        public class StoreEmployeeSignUpDTO : PersonSignUpDTO
        {
            [Required(ErrorMessage = "Role is required.")]
            [StringLength(50, ErrorMessage = "Role cannot exceed 50 characters.")]
            public string? Role { get; set; }

            [Required(ErrorMessage = "Salary is required.")]
            [Range(0.01, double.MaxValue, ErrorMessage = "Salary must be greater than zero.")]
            public float Salary { get; set; }

            [Range(0, int.MaxValue, ErrorMessage = "Years of service cannot be negative.")]
            public int YearsOfService { get; set; } = 0;
            public Guid StoreId { get; set; }
        }

        public class StoreEmployeeReadDto : PersonReadDto
        {
            public required string Role { get; set; }
            public float Salary { get; set; }
            public int YearsOfService { get; set; }
            public Guid StoreId { get; set; }
        }

        public class StoreEmployeeListDto : PersonListDto
        {
            public List<StoreEmployeeReadDto> StoreEmployees { get; set; }
        }
    }
}
