using FusionTech.src.Entity;
using static FusionTech.src.DTO.OrderedGamesDto;

namespace FusionTech.src.DTO
{
    public class OrderDTO
    {
        public class OrderReadDto()
        {
            public Guid Id { get; set; }
            public Guid CustomerId { get; set; }
            public DateTime OrderDate { get; set; }
            // public Guid StoreId { get; set; }
            public List<OrderedGamesReadDto> OrderedGames { get; set; }
        }
        public class OrderCreateDto()
        {
            public DateTime OrderDate { get; set; }
            public List<OrderedGamesCreateDto> OrderedGames { get; set; }
        }
        public class OrderUpdateDto()
        {
            public float TotalPrice { get; set; }
        }

    }
}