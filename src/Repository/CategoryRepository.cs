using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FusionTech.src.Database;
using FusionTech.src.Entity;
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

        public async Task<Category> GetIdAsync(Guid id)
        {
            return await _category.FindAsync(id);
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