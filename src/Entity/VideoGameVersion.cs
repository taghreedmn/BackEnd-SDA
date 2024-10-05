
namespace FusionTech.src.Entity
{
    public class VideoGameVersion
    {
        public Guid VideoGameVersionId { get; set; }
        public double Price { get; set; }
        public Guid VideoGameInfoId { get; set; }
        public Guid ConsoleId { get; set; }

    }
}