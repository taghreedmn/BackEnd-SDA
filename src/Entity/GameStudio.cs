using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FusionTech.src.Entity
{
    public class GameStudio
    {
        public Guid StudioId { get; set; }
        public string? StudioName { get; set; }
        public string? StudioPicturePath { get; set; }
    }
}
