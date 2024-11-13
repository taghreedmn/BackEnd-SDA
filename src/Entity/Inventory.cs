namespace FusionTech.src.Entity
{
    public class Inventory
    {
        [ForeignKey("ViedoGameVersion")]
        public Guid VideoGameVersionId { get; set; }

        [ForeignKey("Store")]
        public Guid StoreId { get; set; }
        public int GameQuantity { get; set; }
        public VideoGameVersion VideoGameVersion { get; set; }
        public Store Store { get; set; }
    }
}
