namespace FusionTech.src.DTO
{
    public class StoreEmployeeDTO : PersonDTO
    {
        public class StoreEmployeeCreateDto : PersonCreateDto
        {
            public string? Role { get; set; }
            public float Salary { get; set; }
            public int YearsOfService { get; set; } = 0;
        }

        public class StoreEmployeeReadDto : PersonSignInDTO
        {
            public string? Role { get; set; }
            public float Salary { get; set; }
            public int YearsOfService { get; set; }
        }
    }
}
