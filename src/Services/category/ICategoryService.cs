namespace FusionTech.src.Services.category
{
    public interface ICategoryService
    {
        Task<CategoryDTO.CategoryBasicDto> CreateOneAsync(CategoryCreateDto createDto);
        Task<List<CategoryDTO.CategoryBasicDto>> GetAllAsync(PaginationOptions paginationOptions);
        Task<CategoryDTO.CategoryDetailedDto> GetByIdAsync(Guid id);
        Task<(List<CategoryDTO.CategoryDetailedDto> categories, int totalCount)> GetCategoryDetailsByNameAsync(string categoryName, PaginationOptions paginationOptions);
        Task<bool> DeleteOneAsync(Guid id);
        Task<bool> UpdateOneAsync(Guid id, CategoryUpdateDto updateDto);
        Task<int> CountCategoryAsync();
    }
}
