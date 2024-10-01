namespace FusionTech.src.DTO
{
    public class PublisherDTO
    {
        public class PublisherCreateDto
        {
            public string? PublisherName { get; set; }
            public string? Email { get; set; }
            public string? Website { get; set; }
            public string? PublisherPicturePath { get; set; }
           
           
        }

        // read data = get data
        public class PublisherReadDto
        {
            public Guid PublisherId { get; set; }
            public string? PublisherName { get; set; }
            public string? Email { get; set; }
            public string? Website { get; set; }
            public string? PublisherPicturePath { get; set; }

        }

        // update
        public class PublisherUpdateDto
        {
            public string? PublisherName { get; set; }
            public string Email { get; set; }
            public string Website { get; set; }
            public string PublisherPicturePath { get; set; }

        }
    }

}