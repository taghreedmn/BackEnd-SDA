using FusionTech.src.Utils;
using static FusionTech.src.DTO.CategoryDTO;

namespace FusionTech.src.Services
{
    public interface ICategoryService
    {
        Task<CategoryReadDto> CreateOneAsync(CategoryCreateDto createDto);
        Task<List<CategoryReadDto>> GetAllAsync(PaginationOptions paginationOptions);
        Task<CategoryReadDto> GetByIdAsync(Guid id);
        Task<bool> DeleteOneAsync(Guid id);
        Task<bool> UpdateOneAsync(Guid id, CategoryUpdateDto updateDto);
    }
}