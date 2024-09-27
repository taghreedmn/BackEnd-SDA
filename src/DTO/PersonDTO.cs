using FusionTech.src.Entity;

namespace FusionTech.src.DTO
{
    public class PersonDTO
    {
        public class PersonCreateDto
        {
            public string? PersonName { get; set; }

            public string? PersonEmail { get; set; }

            public string? PersonPassword { get; set; }

            public string? PersonPhone { get; set; }

            public string? ProfilePicturePath { get; set; }
        }

        public class PersonReadDto
        {
            public int personId { get; set; }
            public string? PersonName { get; set; }
            public string? PersonEmail { get; set; }
            public string? PersonPhone { get; set; }
            public string? ProfilePicturePath { get; set; }
        }
    }
}
