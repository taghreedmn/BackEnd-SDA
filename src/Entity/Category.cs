using System.ComponentModel.DataAnnotations;

namespace FusionTech.src.Entity
{
    public class Category
    {

        public Guid CategoryId { get; set; }
        public required string CategoryName { get; set; }
        public ICollection<VideoGameInfo> Categories { get; set; }

    }
}
