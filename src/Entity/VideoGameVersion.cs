namespace FusionTech.src.Entity
{
    public class VideoGameVersion
    {
        public Guid VideoGameVersionId { get; set; }
        public float Price { get; set; }
        public Guid VideoGameInfoId { get; set; }
        public Guid GameConsoleId { get; set; }
        public ICollection<RatedBy> RatedBies { get; set; }
    }
}
