namespace FusionTech.src.DTO
{
    public class OrderedGamesDto
    {
        public class OrderedGamesReadDto()
        {
            public Guid Id { get; set; }
            public Guid VideoGameVersionID { get; set; }
            public Guid OrderId { get; set; }
            public int Quantity { get; set; }
            public VideoGameVersionReadDto VideoGameRead { get; set; }
        }

        public class OrderedGamesCreateDto()
        {
            public Guid OrderId { get; set; }
            public Guid VideoGameVersionID { get; set; }
            public int Quantity { get; set; }
        }

        public class OrderedGamesUpdateDto()
        {
            public float TotalPrice { get; set; }
        }
    }
}
