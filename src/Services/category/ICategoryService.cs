using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FusionTech.src.Utils;
using static FusionTech.src.DTO.CategoryDTO;

namespace FusionTech.src.Services
{
    public interface ICategoryService
    {
        Task<CategoryReadDto> CreateOneAsync(CategoryCreateDto createDto);
        Task<List<CategoryReadDto>> GetAllAsync(PaginationOptions paginationOptions);
        Task<CategoryReadDto> GetByIdAsync(Guid Id);
        Task<bool> DeleteOneAsync(Guid Id);
        Task<bool> UpdateOneAsync(Guid Id, CategoryUpdateDto updateDto);
    }
}