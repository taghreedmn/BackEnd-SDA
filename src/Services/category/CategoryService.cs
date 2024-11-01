namespace FusionTech.src.Services.category
{
    public class CategoryService : ICategoryService
    {
        protected readonly CategoryRepository _categoryRepository;
        protected readonly IMapper _mapper;

        public CategoryService(CategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<CategoryDTO.CategoryBasicDto> CreateOneAsync(CategoryCreateDto createDto)
        {
            var category = _mapper.Map<Category>(createDto);
            var categoryCreated = await _categoryRepository.CreateOneAsync(category);
            return _mapper.Map<CategoryDTO.CategoryBasicDto>(categoryCreated);
        }

        public async Task<List<CategoryDTO.CategoryBasicDto>> GetAllAsync(PaginationOptions paginationOptions)
        {
            var categoryList = await _categoryRepository.GetAllAsync(paginationOptions);
            return _mapper.Map<List<Category>, List<CategoryDTO.CategoryBasicDto>>(categoryList);
        }

        public async Task<int> CountCategoryAsync()
        {
            return await _categoryRepository.CountAsync();
        }

        public async Task<CategoryDetailedDto> GetByIdAsync(Guid id)
        {
            var foundCategory = await _categoryRepository.GetByIdAsync(id);
            if (foundCategory == null)
            {
                throw CustomException.NotFound($"Category with ID {id} not found");
            }
            return _mapper.Map<CategoryDetailedDto>(foundCategory);
        }

        public async Task<(List<CategoryDetailedDto> categories, int totalCount)> GetCategoryDetailsByNameAsync(string categoryName, PaginationOptions paginationOptions)
        {
            var (foundCategory, totalCount) = await _categoryRepository.GetCategoryDetailsByNameAsync(categoryName, paginationOptions);

            if (foundCategory == null || foundCategory.Count == 0)
            {
                throw CustomException.NotFound($"No categories found with the name {categoryName}");
            }

            var categoryLists = _mapper.Map<List<Category>, List<CategoryDetailedDto>>(foundCategory);
            return (categoryLists, totalCount);
        }

        public async Task<bool> DeleteOneAsync(Guid id)
        {
            var foundCategory = await _categoryRepository.GetByIdAsync(id);
            if (foundCategory == null)
            {
                throw CustomException.NotFound($"Category with ID {id} not found");
            }
            bool isDeleted = await _categoryRepository.DeleteOneAsync(foundCategory);
            if (!isDeleted)
            {
                throw CustomException.InternalError("Failed to delete the category");
            }
            return true;
        }

        public async Task<bool> UpdateOneAsync(Guid id, CategoryUpdateDto updateDto)
        {
            var foundCategory = await _categoryRepository.GetByIdAsync(id);
            if (foundCategory == null)
            {
                throw CustomException.NotFound($"Category with ID {id} not found");
            }
            _mapper.Map(updateDto, foundCategory);
            bool isUpdated = await _categoryRepository.UpdateOneAsync(foundCategory);
            if (!isUpdated)
            {
                throw CustomException.InternalError("Failed to update the category");
            }
            return true;
        }
    }
}
