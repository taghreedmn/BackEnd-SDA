using FusionTech.src.Entity;
using static FusionTech.src.DTO.OrderedGamesDto;

namespace FusionTech.src.DTO
{
    public class OrderDTO
    {
        public class OrderReadDto()
        {
            public Guid OrderId { get; set; }

            public DateTime OrderDate { get; set; }
            public double TotalPrice { get; set; }
            public int PaymentId { get; set; }
            public Guid StoreId { get; set; }
            public int EmployeeId { get; set; }
            public List<OrderedGamesReadDto> OrderedGames { get; set; }
        }

        public class OrderCreateDto()
        {
            public int EmployeeId { get; set; }
            public Guid StoreId { get; set; }
            public Guid PaymentId { get; set; }
            public List<OrderedGamesCreateDto> OrderedGames { get; set; } // Removed the DTO to make things easier
            // public List<OrderedGamesCreateDto> OrderedGames { get; set; }
            // public double Price { get; set; }
            // public Guid videoGameVerionID { get; set; }
            // public Guid ConsoleId { get; set; }
        }

        public class OrderUpdateDto()
        {
            public float TotalPrice { get; set; }
        }
    }
}
