namespace FusionTech.src.Services.category
{
    public interface ICategoryService
    {
        Task<CategoryBasicDto> CreateOneAsync(CategoryCreateDto createDto);
        Task<List<CategoryBasicDto>> GetAllAsync(PaginationOptions paginationOptions);
        Task<CategoryDetailedDto> GetByIdAsync(Guid id);
        Task<(List<CategoryDetailedDto> categories, int totalCount)> GetCategoryDetailsByNameAsync(string CategoryName, PaginationOptions paginationOptions);
        Task<bool> DeleteOneAsync(Guid id);
        Task<bool> UpdateOneAsync(Guid id, CategoryUpdateDto updateDto);
        Task<int> CountCategoryAsync();
    }
}
