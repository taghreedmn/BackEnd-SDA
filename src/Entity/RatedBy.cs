using System.ComponentModel.DataAnnotations;

namespace FusionTech.src.Entity
{
    public class RatedBy
    {
        public Guid RatedId { get; set; }

        [Required(ErrorMessage = "Rating is required.")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        public float Rating { get; set; }

        [StringLength(500, ErrorMessage = "Comment cannot exceed 500 characters.")]
        public string Comment { get; set; }
        public Guid VideoGameVersionId  { get; set; }
        public Guid PersonId { get; set; }
    }
}