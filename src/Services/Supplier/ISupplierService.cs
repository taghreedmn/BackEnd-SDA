namespace FusionTech.src.Services.supplier
{
    public interface ISupplierService
    {
        Task<SupplierReadDto> CreateOneAsync(SupplierCreateDto createDto);
        Task<IEnumerable<SupplierReadDto>> GetAllAsync();
        Task<SupplierReadDto?> GetByIdAsync(Guid id);
        Task<bool> DeleteOneAsync(Guid id);
        Task<bool> UpdateOneAsync(Guid id, SupplierUpdateDto updateDto);
    }
}
