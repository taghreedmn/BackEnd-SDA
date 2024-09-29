namespace sda_3_online_Backend_Teamwork.src.DTO
{
    public class StudioDTO
    {
        public class CreatStudioDTO
        {
            public string StudioName { get; set; }
        }

        public class ReadStudioDTO
        {
            public Guid StudioId { get; set; }
            public string StudioName { get; set; }
        }

        public class UpdateStudioDTO
        {
            public Guid StudioId { get; set; }
            public string StudioName { get; set; }
        }
    }
}
