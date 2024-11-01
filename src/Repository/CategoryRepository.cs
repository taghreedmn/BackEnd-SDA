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
           IQueryable<Category> query = _category.Include(c => c.VideoGameInfos)
                                                 .ThenInclude(vi => vi.VideoGameVersions);

         // Search filtering
        if (!string.IsNullOrEmpty(paginationOptions.Search))
        {
            query = query.Where(c => c.CategoryName.Contains(paginationOptions.Search, StringComparison.OrdinalIgnoreCase));
        }

         // Min and Max Price Filtering
        if (paginationOptions.MinPrice.HasValue)
       {
           query = query.Where(c => c.VideoGameInfos.Any(vi => vi.VideoGameVersions.Any(v => v.Price >= paginationOptions.MinPrice.Value)));
       }
    
        if (paginationOptions.MaxPrice.HasValue)
       {
          query = query.Where(c => c.VideoGameInfos.Any(vi => vi.VideoGameVersions.Any(v => v.Price <= paginationOptions.MaxPrice.Value)));
       }

          // Pagination
         var categories = await query
            .Skip(paginationOptions.Offset)
            .Take(paginationOptions.Limit)
            .ToListAsync();

         return categories;
        }


        public async Task<int> CountAsync()
        {
            return await _category.CountAsync();
        }

        public async Task<Category> GetByIdAsync(Guid id)
        {
            // Corrected access to the Category
            return await _category.Include(c => c.VideoGameInfos)
                                  .ThenInclude(vi => vi.VideoGameVersions)
                                  .FirstOrDefaultAsync(c => c.CategoryId == id);
        }

        // public async Task<List<Category>> GetCategoryDetailsByNameAsync(string categoryName)
        // {
        //     return await _category
        //         .Include(c => c.VideoGameInfos)
        //         .ThenInclude(vi => vi.VideoGameVersions)
        //         .Where(c => c.CategoryName.ToLower() == categoryName.ToLower())
        //         .ToListAsync();
        // }
        public async Task<(List<Category>, int)> GetCategoryDetailsByNameAsync(string categoryName, PaginationOptions paginationOptions)
        {
          IQueryable<Category> query = _category
            .Include(c => c.VideoGameInfos)
            .ThenInclude(vi => vi.VideoGameVersions)
            .Where(c => c.CategoryName.Equals(categoryName, StringComparison.OrdinalIgnoreCase));

    
            var totalCount = await query.CountAsync();

           // Pagination
           var categories = await query
             .Skip(paginationOptions.Offset)
             .Take(paginationOptions.Limit)
             .ToListAsync();

          return (categories, totalCount);
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

        public async Task<Category?> PatchOneAsync(Guid id, Category updatedFields)
        {
            var existingCategory = await GetByIdAsync(id);

            if (existingCategory == null)
            {
                return null; // Category not found
            }

            // Update only the fields that are not null
            if (!string.IsNullOrEmpty(updatedFields.CategoryName))
            {
                existingCategory.CategoryName = updatedFields.CategoryName;
            }

            // Save the changes
            await _databaseContext.SaveChangesAsync();

            return existingCategory;
        }
    }
}
