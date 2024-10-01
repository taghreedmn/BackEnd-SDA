using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FusionTech.src.Utils;
using static FusionTech.src.DTO.SupplierDTO;

namespace FusionTech.src.Services.supplier
{
    public interface ISupplierService
    {
        Task<SupplierReadDto> CreateOneAsync(SupplierCreateDto createDto);
        Task<List<SupplierReadDto>> GetAllAsync();
        Task<SupplierReadDto> GetByIdAsync(Guid id);
        Task<bool> DeleteOneAsync(Guid id);
        Task<bool> UpdateOneAsync(Guid id, SupplierUpdateDto updateDto);
    }
}
