using FusionTech.src.Utils;
using static FusionTech.src.DTO.PaymentDTO;

namespace FusionTech.src.Services.payment
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