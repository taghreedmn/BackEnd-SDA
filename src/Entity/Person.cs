namespace FusionTech.src.Entity
{
    public abstract class Person
    {
        public int PersonId { get; set; }

        public required string PersonName { get; set; }

        public required string PersonEmail { get; set; }
        [PasswordComplexity]
        public required string PersonPassword { get; set; }

        public string? PersonPhoneNumber { get; set; }

        public string? ProfilePicturePath { get; set; }
        public static readonly PersonType PersonType = PersonType.Person;

        public required byte[] salt { get; set; }

    }
}
