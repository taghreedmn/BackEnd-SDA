namespace FusionTech.src.DTO
{
    public class VideoGameVersionDTO
    {
        public class VideoGameVersionCreateDto
        {
            public Guid VideoGameInfoId { get; set; }
            public Guid GameConsoleId { get; set; }
            public float Price { get; set; }
        }

        public class VideoGameVersionUpdateDto
        {
            public Guid VideoGameVersionId { get; set; }
            public Guid GameConsoleId { get; set; }
            public float? Price { get; set; }
        }

        public class VideoGameVersionReadDto
        {
            public Guid VideoGameVersionId { get; set; }
            public Guid VideoGameInfoId { get; set; }
            public float Price { get; set; }
            public Guid GameConsoleId { get; set; }
            // quantity = 5 -- Rating
        }
    }
}
