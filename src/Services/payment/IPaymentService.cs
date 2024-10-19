namespace FusionTech.src.Services.Payment
{
    public interface IPaymentService
    {
        Task<PaymentReadDto> CreateOneAsync(PaymentCreateDto createDto);
        Task<List<PaymentReadDto>> GetAllAsync(PaginationOptions paginationOptions);
        Task<PaymentReadDto> GetByIdAsync(Guid id);
        Task<bool> DeleteOneAsync(Guid id);
        Task<bool> UpdateOneAsync(Guid id, PaymentUpdateDto updateDto);
    }
}
