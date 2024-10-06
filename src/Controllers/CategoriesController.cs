using FusionTech.src.Services.category;
using FusionTech.src.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using static FusionTech.src.DTO.CategoryDTO;

namespace FusionTech.src.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class CategoriesController : ControllerBase
    {
        protected readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [Authorize(Policy = "admin")]
        [HttpPost]
        public async Task<ActionResult<CategoryReadDto>> CreateOne(
            [FromBody] CategoryCreateDto createDto
        )
        {
            var categoryCreated = await _categoryService.CreateOneAsync(createDto);
            return Created($"api/v1/categories/{categoryCreated.CategoryId}", categoryCreated);
        }

        [HttpGet]
        public async Task<ActionResult<CategoryReadDto>> GetCategory(
            [FromQuery] PaginationOptions paginationOptions
        )
        {
            var categoryList = await _categoryService.GetAllAsync(paginationOptions);
            return Ok(categoryList);
        }

        // [HttpGet("{Id}")]
        // public async Task<ActionResult<CategoryReadDto>> GetCategoryById([FromRoute] Guid Id)
        // {
        //     var category = await _categoryService.GetByIdAsync(Id);
        //     return Ok(category);
        // }
        [HttpGet("{CategoryName}")]
        public async Task<ActionResult<CategoryReadDto>> GetCategoryDetailsByNameAsync(
            [FromRoute] string CategoryName
        )
        {
            var category = await _categoryService.GetCategoryDetailsByNameAsync(CategoryName);
            return Ok(category);
        }

        [Authorize(Policy = "admin")]
        [HttpDelete("{Id}")]
        public async Task<ActionResult<CategoryReadDto>> DeleteOne([FromRoute] Guid Id)
        {
            var category = await _categoryService.GetByIdAsync(Id);
            await _categoryService.DeleteOneAsync(category.CategoryId);
            return Ok(category);
        }

        [Authorize(Policy = "admin")]
        [HttpPut("{Id}")]
        public async Task<ActionResult> UpdateCategory(Guid id, CategoryUpdateDto updateDto)
        {
            await _categoryService.UpdateOneAsync(id, updateDto);
            return NoContent();
        }
    }
}
