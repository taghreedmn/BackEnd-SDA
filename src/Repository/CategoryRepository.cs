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

        public async Task<List<Category>> GetAllAsync()
        {
            return await _category.ToListAsync();
        }

        public async Task<List<Category>> GetAllDetailedAsync(SearchParameters searchParameters)
        {
            IQueryable<Category> query = _category
                .Include(c => c.VideoGameInfos)
                .ThenInclude(vi => vi.VideoGameVersions);

            // Search filtering
            if (!string.IsNullOrEmpty(searchParameters.Search))
            {
                query = query.Where(c =>
                    c.CategoryName.Contains(
                        searchParameters.Search,
                        StringComparison.OrdinalIgnoreCase
                    )
                );
            }

            searchParameters.IsValid();
            if (searchParameters.MinPrice != 0)
            {
                query = query.Where(c =>
                    c.VideoGameInfos.Any(vi =>
                        vi.VideoGameVersions.Any(v => v.Price >= searchParameters.MinPrice)
                    )
                );
            }

            if (searchParameters.MaxPrice != 10000) // Same as the maximum number written inside SearchParamter class
            {
                query = query.Where(c =>
                    c.VideoGameInfos.Any(vi =>
                        vi.VideoGameVersions.Any(v => v.Price <= searchParameters.MaxPrice)
                    )
                );
            }

            // Count total categories for pagination
            int totalCount = await query.CountAsync();

            // Pagination
            var categories = await query
                .Skip(searchParameters.Offset)
                .Take(searchParameters.Limit)
                .ToListAsync();

            return categories;
        }

        public async Task<int> CountAsync()
        {
            return await _category.CountAsync();
        }

        public async Task<Category> GetByIdAsync(Guid id)
        {
            return await _category
                .Include(c => c.VideoGameInfos)
                .ThenInclude(vi => vi.VideoGameVersions)
                .FirstOrDefaultAsync(c => c.CategoryId == id);
        }

        public async Task<List<Category>> GetCategoryDetailsByNameAsync(string CategoryName)
        {
            return await _category
                .Include(c => c.VideoGameInfos)
                .ThenInclude(vi => vi.VideoGameVersions)
                .Where(c => c.CategoryName.ToLower() == CategoryName.ToLower())
                .ToListAsync();
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
                return null;
            }

            if (!string.IsNullOrEmpty(updatedFields.CategoryName))
            {
                existingCategory.CategoryName = updatedFields.CategoryName;
            }

            await _databaseContext.SaveChangesAsync();

            return existingCategory;
        }
    }
}
