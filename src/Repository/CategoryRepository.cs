using FusionTech.src.Database;
using FusionTech.src.Entity;
using FusionTech.src.Utils;
using Microsoft.EntityFrameworkCore;

namespace FusionTech.src.Repository
{
    public class CategoryRepository
    {
        protected DbSet<Category> _category;
        protected DatabaseContext _databaseContext;

        public CategoryRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
            _category = databaseContext.Set<Category>();
        }

        public async Task<Category> CreateOneAsync(Category newCategory)
        {
            await _category.AddAsync(newCategory);
            await _databaseContext.SaveChangesAsync();
            return newCategory;
        }

        public async Task<List<Category>> GetAllAsync(PaginationOptions paginationOptions)
        {
            var result = _category.Where(c =>
                c.CategoryName.ToLower().Contains(paginationOptions.Search.ToLower())
            );
            return await result
                .Skip(paginationOptions.Offset)
                .Take(paginationOptions.Limit)
                .ToListAsync();
        }

        public async Task<Category> GetByIdAsync(Guid id)
        {
            return await _category.FindAsync(id);
        }
        public async Task<List<Category>> GetCategoryDetailsByNameAsync(string CategoryName)
        {
            return await _category
            .Include(c => c.Categories).Where(c => c.CategoryName.ToLower() == CategoryName.ToLower()).ToListAsync();
        }

        public async Task<bool> DeleteOneAsync(Category category)
        {
            _category.Remove(category);
            await _databaseContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateOneAsync(Category updateCategory)
        {
            _category.Update(updateCategory);
            await _databaseContext.SaveChangesAsync();
            return true;
        }
    }
}
