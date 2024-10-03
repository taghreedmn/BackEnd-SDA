namespace FusionTech.src.Entity
{
    public class DevelopedByDTO
    {
        public class CreateDevelopedByDTO
        {
            public Guid GameStudioId { get; set; }
            public Guid VideoGameInfoId { get; set; }
        }

        public class ReadDevelopedByDTO
        {
            public Guid GameStudioId { get; set; }
            public Guid VideoGameInfoId { get; set; }
        }

        public class UpdateDevelopedByDTO
        {
            public Guid GameStudioId { get; set; }
            public Guid VideoGameInfoId { get; set; }
        }
    }
}
