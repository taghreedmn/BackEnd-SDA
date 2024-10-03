namespace FusionTech.src.DTO
{
    public class PlayedInDTO
    {
        public class CreatePlayedInDTO
        {
            public Guid GameConsoleId { get; set; }
            public Guid VideoGameInfoId { get; set; }
        }

        public class ReadPlayedInDTO
        {
            public Guid GameConsoleId { get; set; }
            public Guid VideoGameInfoId { get; set; }
        }

        public class UpdatePlayedInDTO
        {
            public Guid GameConsoleId { get; set; }
            public Guid VideoGameInfoId { get; set; }
        }
    }
}
