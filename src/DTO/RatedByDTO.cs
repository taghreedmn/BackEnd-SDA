namespace FusionTech.src.DTO
{
    public class RatedByDTO
    {
        public class VideoGameRatingReadDto
        {
            public float Rating { get; set; }
            public string? Comment { get; set; }
            public int PersonId { get; set; }
            public required string PersonName { get; set; }
            public string? ProfilePicturePath { get; set; }
        }
    }
}
