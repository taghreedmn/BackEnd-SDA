
namespace FusionTech.src.Entity
{
    public class VideoGameInfo
    {
        public Guid GameId { get; set; }
        public string? GameName { get; set; }
        public float Price { get; set; }
        public string? Description { get; set; }
        public string? YearOfRelease { get; set; }
        public int TotalRating { get; set; }
        public Guid PublisherId { get; set; }
        public string? GamePicturePath { get; set; }
    }
}
