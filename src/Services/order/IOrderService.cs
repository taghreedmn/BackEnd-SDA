using FusionTech.src.Entity;
using FusionTech.src.Utils;
using static FusionTech.src.DTO.OrderDTO;

namespace FusionTech.src.Services.order
{
    public interface IOrderService
    {
        Task<OrderReadDto> CreateOneAsync(int userId, OrderCreateDto createDto);
        Task<List<OrderReadDto>> GetOrderByIdAsync(int CustomerId);
    }
}
