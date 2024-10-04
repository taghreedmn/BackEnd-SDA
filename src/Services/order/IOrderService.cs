using FusionTech.src.Entity;
using FusionTech.src.Utils;
using static FusionTech.src.DTO.OrderDTO;

namespace FusionTech.src.Services.order
{
    public interface IOrderService
    {
        Task<OrderReadDto> CreateOneAsync(Guid userId, OrderCreateDto createDto);
        Task<List<OrderReadDto>> GetAllOrdersAsync();
        Task<List<OrderReadDto>> GetOrderByIdAsync(Guid CustomerId);
    }
}