namespace FusionTech.src.Services.category
{
    public interface ICategoryService
    {
        Task<CategoryBasicDto> CreateOneAsync(CategoryCreateDto createDto);
        Task<List<CategoryBasicDto>> GetAllAsync(PaginationOptions paginationOptions);
        Task<CategoryDetailedDto> GetByIdAsync(Guid Id);
        Task<List<CategoryDetailedDto>> GetCategoryDetailsByNameAsync(string CategoryName);
        Task<bool> DeleteOneAsync(Guid Id);
        Task<bool> UpdateOneAsync(Guid Id, CategoryUpdateDto updateDto);
        Task<int> CountCategoryAsync();
    }
}
