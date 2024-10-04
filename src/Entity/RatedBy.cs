using System.ComponentModel.DataAnnotations;

namespace FusionTech.src.Entity
{
    public class RatedBy
    {
        public Guid RatedId { get; set; }
        public float Rating { get; set; }
        public string? Comment { get; set; }
        public Guid GameId  { get; set; }
        public Guid PersonId { get; set; }
    }
}