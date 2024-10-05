using AutoMapper;
using FusionTech.src.DTO;
using FusionTech.src.Repository;
using FusionTech.src.Utils;
using Microsoft.EntityFrameworkCore.Metadata;
using static FusionTech.src.DTO.CategoryDTO;

namespace FusionTech.src.Services.Category
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
            return _mapper.Map<Entity.Category, CategoryReadDto>(categoryCreated);
        }

        public async Task<List<CategoryDTO.CategoryReadDto>> GetAllAsync(
            PaginationOptions paginationOptions
        )
        {
            var categoryList = await _categoryRepository.GetAllAsync(paginationOptions);
            return _mapper.Map<List<Entity.Category>, List<CategoryReadDto>>(categoryList);
        }

        public async Task<CategoryDTO.CategoryReadDto> GetByIdAsync(Guid id)
        {
            var foundCategory = await _categoryRepository.GetByIdAsync(id);
            if(foundCategory==null)
            {
                throw CustomExeption.NotFound($"category with {id} can not find");
            }
            return _mapper.Map<Entity.Category, CategoryReadDto>(foundCategory);
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

        public async Task<bool> UpdateOneAsync(Guid id, CategoryUpdateDto updateDto)
        {
            var foundCategory = await _categoryRepository.GetByIdAsync(id);
            if (foundCategory == null)
            {
                throw CustomExeption.NotFound($"Category with ID {id} not found");
            }
            _mapper.Map(updateDto, foundCategory);
            bool isUpdated = await _categoryRepository.UpdateOneAsync(foundCategory);
            if (!isUpdated)
            {
                throw CustomExeption.InternalError("Failed to update the category");
            }
            return true;
        }

    }
}
