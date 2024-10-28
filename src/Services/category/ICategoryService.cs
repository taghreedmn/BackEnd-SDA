namespace FusionTech.src.Services.category
{
    public interface ICategoryService
    {
        Task<CategoryReadDtoWithoutGames> CreateOneAsync(CategoryCreateDto createDto);
        Task<List<CategoryReadDtoWithoutGames>> GetAllAsync(PaginationOptions paginationOptions);
        Task<CategoryReadDtoWithGames> GetByIdAsync(Guid Id);
        Task<List<CategoryReadDtoWithGames>> GetCategoryDetailsByNameAsync(string CategoryName);
        Task<bool> DeleteOneAsync(Guid Id);
        Task<bool> UpdateOneAsync(Guid Id, CategoryUpdateDto updateDto);
    }
}
