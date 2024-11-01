namespace FusionTech.src.Entity
{
    public class RatedBy
{
    public Guid RatedById { get; set; }
    public float Rating { get; set; }

    [StringLength(500, ErrorMessage = "Comment cannot exceed 500 characters.")]
    public string? Comment { get; set; }

    public Guid VideoGameInfoId { get; set; }
    public VideoGameInfo VideoGameInfo { get; set; }

    public int PersonId { get; set; }

    [ForeignKey("PersonId")]
    public Customer Customer { get; set; }
}

}
