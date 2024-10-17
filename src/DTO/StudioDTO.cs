namespace FusionTech.src.DTO
{
    public class StudioDTO
    {
        public class CreateStudioDTO
        {
            [Required(ErrorMessage = "Studio name is required.")]
            [StringLength(100, ErrorMessage = "Studio name cannot exceed 100 characters.")]
            public string? StudioName { get; set; }
            public string? StudioPicturePath { get; set; }
        }

        public class ReadStudioDTO
        {
            public Guid GameStudioId { get; set; }
            public string? StudioName { get; set; }
            public string? StudioPicturePath { get; set; }
        }

        public class UpdateStudioDTO
        {
            public Guid GameStudioId { get; set; }

            [StringLength(100, ErrorMessage = "Studio name cannot exceed 100 characters.")]
            public string? StudioName { get; set; }
            public string? StudioPicturePath { get; set; }
        }
    }
}
