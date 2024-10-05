using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FusionTech.src.Entity
{

  public class VideoGameInfo
  {
    public Guid VideoGameInfoId { get; set; }
    public string? GameName { get; set; }
    public string? Description { get; set; }
    public string? YearOfRelease { get; set; }
    public int TotalRating { get; set; }
    public Guid PublisherId { get; set; }
   public string? GamePicturePath { get; set; }
    public ICollection<GameStudio> GameStudios { get; set; }
    public ICollection<Category> Categoreis { get; set; }

  }
}
