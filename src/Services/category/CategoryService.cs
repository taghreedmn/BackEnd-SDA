using AutoMapper;
using FusionTech.src.DTO;
using FusionTech.src.Entity;
using FusionTech.src.Repository;
using FusionTech.src.Utils;
using Microsoft.EntityFrameworkCore.Metadata;
using static FusionTech.src.DTO.CategoryDTO;

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

        public async Task<CategoryDTO.CategoryReadDto> CreateOneAsync(
            CategoryDTO.CategoryCreateDto createDto
        )
        {
            var category = _mapper.Map<CategoryCreateDto, Entity.Category>(createDto);
            var categoryCreated = await _categoryRepository.CreateOneAsync(category);
            return _mapper.Map<Category, CategoryReadDto>(categoryCreated);
        }

        public async Task<List<CategoryDTO.CategoryReadDto>> GetAllAsync(
            PaginationOptions paginationOptions
        )
        {
            var categoryList = await _categoryRepository.GetAllAsync(paginationOptions);
            return _mapper.Map<List<Category>, List<CategoryReadDto>>(categoryList);
        }

        public async Task<CategoryDTO.CategoryReadDto> GetByIdAsync(Guid id)
        {
            var foundCategory = await _categoryRepository.GetByIdAsync(id);
            return _mapper.Map<Category, CategoryReadDto>(foundCategory);
        }

        public async Task<bool> DeleteOneAsync(Guid id)
        {
            var foundCategory = await _categoryRepository.GetByIdAsync(id);
            bool isDelete = await _categoryRepository.DeleteOneAsync(foundCategory);
            if (isDelete)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateOneAsync(Guid id, CategoryDTO.CategoryUpdateDto updateDto)
        {
            var foundCategory = await _categoryRepository.GetByIdAsync(id);
            if (foundCategory == null)
            {
                return false;
            }
            _mapper.Map(updateDto, foundCategory);
            return await _categoryRepository.UpdateOneAsync(foundCategory);
        }

    }
}
