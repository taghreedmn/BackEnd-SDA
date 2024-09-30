namespace FusionTech.src.DTO
{
    public class CustomerDTO : PersonDTO
    {
        public class CustomerCreateDto : PersonCreateDto
        {
            public int Age { get; set; }
        }

        public class CustomerReadDto : PersonSignInDTO
        {
            public int Age { get; set; }
        }
    }
}
