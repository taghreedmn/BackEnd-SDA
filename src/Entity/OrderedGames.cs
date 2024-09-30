namespace FusionTech.src.Entity
{
    public class OrderedGames
    {
        public Guid OrderId { get; set; }
        public Guid videoGameID { get; set; }
        public int OrderQuantity { get; set; }
    }
}