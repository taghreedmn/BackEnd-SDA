using System.ComponentModel.DataAnnotations;

namespace FusionTech.src.Entity
{
    public class VideoGameInfo
    {
        public Guid GameId { get; set; }

        [Required(ErrorMessage = "Game name is required.")]
        [StringLength(100, ErrorMessage = "Game name cannot exceed 100 characters.")]
        public string? GameName { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than zero.")]
        public float Price { get; set; }

        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Year of release is required.")]
        [DataType(DataType.Date)]
        public string YearOfRelease { get; set; }
        

        [Range(1, 5, ErrorMessage = "Total rating must be between 1 and 5.")]
        public int TotalRating { get; set; }
        public Guid PublisherId { get; set; }

        [StringLength(200, ErrorMessage = "Game picture path cannot exceed 200 characters.")]
        public string? GamePicturePath { get; set; }
        public Guid CategoryId  { get; set; }
        public Category Category{ get; set; }
    }
}
