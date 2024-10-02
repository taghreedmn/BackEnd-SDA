using FusionTech.src.Entity;
using static FusionTech.src.DTO.OrderedGamesDto;

namespace FusionTech.src.DTO
{
    public class OrderDTO
    {
        public class OrderReadDto ()
        {
            public Guid Id { get; set; }
            public Guid CustomerId { get; set; }
            public List<OrderedGamesReadDto> OrderedGames {get; set;} 
        }
        public class OrderCreateDto()
        {
            public List<OrderedGamesReadDto> OrderGames{get;set;}

        }
        public class OrderUpdateDto()
        {
            public float TotalPrice { get; set; }
        }
        
    }
}