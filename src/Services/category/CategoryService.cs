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

        public async Task<CategoryDTO.CategoryBasicDto> CreateOneAsync(
          CategoryCreateDto createDto
        )
        {
            var category = _mapper.Map<CategoryCreateDto, Category>(createDto);
            var categoryCreated = await _categoryRepository.CreateOneAsync(category);
            return _mapper.Map<Category, CategoryBasicDto>(categoryCreated);
        }

        public async Task<List<CategoryBasicDto>> GetAllAsync(
            PaginationOptions paginationOptions
        )
        {
            var categoryList = await _categoryRepository.GetAllAsync(paginationOptions);
            return _mapper.Map<List<Category>, List<CategoryBasicDto>>(categoryList);
        }
        public async Task<int> CountCategoryAsync()
        {
            // return 100
            return await _categoryRepository.CountAsync();
        }



        public async Task<CategoryDetailedDto> GetByIdAsync(Guid id)
        {
            var foundCategory = await _categoryRepository.GetByIdAsync(id);
            if (foundCategory == null)
            {
                throw CustomException.NotFound($"Category with ID {id} not found");
            }
            return _mapper.Map<Category, CategoryDetailedDto>(foundCategory);
        }
        public async Task<List<CategoryDetailedDto>> GetCategoryDetailsByNameAsync(string CategoryName)
        {
            var foundCategory = await _categoryRepository.GetCategoryDetailsByNameAsync(CategoryName);
            if (foundCategory == null || foundCategory.Count == 0)
            {
                throw CustomException.NotFound($"No categories found with the name {CategoryName}");
            }
            var categoryLists = _mapper.Map<List<Category>, List<CategoryDetailedDto>>(foundCategory);
            return categoryLists;
        }

        public async Task<bool> DeleteOneAsync(Guid id)
        {
            var foundCategory = await _categoryRepository.GetByIdAsync(id);
            if (foundCategory == null)
            {
                throw CustomException.NotFound($"Category with ID {id} not found");
            }
            bool isDelete = await _categoryRepository.DeleteOneAsync(foundCategory);
            if (!isDelete)
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
