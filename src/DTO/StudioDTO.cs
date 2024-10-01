namespace FusionTech.src.DTO
{
    public class StudioDTO
    {
        public class CreatStudioDTO
        {
            public string StudioName { get; set; }
            public string StudioPicturePath { get; set; }
        }

        public class ReadStudioDTO
        {
            public Guid GameStudioId { get; set; }
            public string StudioName { get; set; }
             public string StudioPicturePath { get; set; }
        }

        public class UpdateStudioDTO
        {
            public Guid GameStudioId { get; set; }
            public string StudioName { get; set; }
             public string StudioPicturePath { get; set; }
        }
    }
}
