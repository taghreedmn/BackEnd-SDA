namespace FusionTech.src.Entity
{
    public class GameStudio
    {

        public Guid GameStudioId { get; set; }

        [Required(ErrorMessage = "Studio name is required.")]
        [StringLength(25, ErrorMessage = "Studio name cannot exceed 25 characters.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Studio name can only contain letters and spaces.")]
        // [DisplayName("Studio Name")]
        public string StudioName { get; set; }

        [StringLength(200, ErrorMessage = "Studio picture path cannot exceed 200 characters.")]
        public string StudioPicturePath { get; set; }
        public ICollection<VideoGameInfo> VideoGames { get; set; }

    }
}
