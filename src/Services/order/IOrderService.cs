namespace FusionTech.src.Services.order
{
    public interface IOrderService
    {
        Task<OrderReadDto> CreateOneAsync(int userId, OrderCreateDto createDto);
        Task<List<OrderReadDto>> GetOrderByIdAsync(int CustomerId);
        Task<List<OrderReadDto>> GetAllAsync();
        Task<int> CountOrdersAsync();
    }
}
