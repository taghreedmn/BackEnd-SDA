namespace FusionTech.src.DTO
{
    public class CustomerDTO : PersonDTO
    {
        public class CustomerCreateDto : PersonCreateDto
        {
            public int Age { get; set; }
        }

        public class CustomerReadDto : PersonReadDto
        {
            public int Age { get; set; }
        }
    }
}
