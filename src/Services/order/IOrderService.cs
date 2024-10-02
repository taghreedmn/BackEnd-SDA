using FusionTech.src.Entity;
using FusionTech.src.Utils;
using static FusionTech.src.DTO.OrderDTO;

namespace FusionTech.src.Services.order
{
    public interface IOrderService
    {
        Task<OrderReadDto> CreateOneAsync(Guid userId, OrderCreateDto createDto);
        Task<List<OrderReadDto>> GetAllAsync(PaginationOptions paginationOptions);
        Task<OrderReadDto> GetByIdAsync(Guid Id);
        Task<bool> DeleteOneAsync(Guid Id);
        Task<bool> UpdateOneAsync(Guid Id, OrderUpdateDto updateDto);
    }
}