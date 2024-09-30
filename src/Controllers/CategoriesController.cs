using FusionTech.src.Services.Category;
using FusionTech.src.Utils;
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

        [HttpPost]
        public async Task<ActionResult<CategoryReadDto>> CreateOne(
            [FromBody] CategoryCreateDto createDto
        )
        {
            var categoryCreated = await _categoryService.CreateOneAsync(createDto);
            return Created($"api/v1/categories/{categoryCreated.Id}", categoryCreated);
            // return Ok(categoryCreated);
        }

        [HttpGet]
        public async Task<ActionResult<CategoryReadDto>> GetCategory(
            [FromQuery] PaginationOptions paginationOptions
        )
        {
            var categoryList = await _categoryService.GetAllAsync(paginationOptions);
            return Ok(categoryList);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<CategoryReadDto>> GetCategoryById([FromRoute] Guid Id)
        {
            var category = await _categoryService.GetByIdAsync(Id);
            return Ok(category);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<CategoryReadDto>> DeleteOne([FromRoute] Guid Id)
        {
            var category = await _categoryService.GetByIdAsync(Id);
            if (category == null)
            {
                return NotFound();
            }
            await _categoryService.DeleteOneAsync(category.Id);
            return Ok(category);
        }

        //         [HttpPut("{Id}")]
        //         public ActionResult PutCategory(Guid id, Category updateCategory)
        //         {
        //             Category? foundCategory = categories.FirstOrDefault(c => c.Id == id);
        //             if (foundCategory == null)
        //             {
        //                 return NotFound();
        //             }

        //             foundCategory.Id = updateCategory.Id;
        //             foundCategory.CategoryName = updateCategory.CategoryName;
        //             return NoContent();
        //         }
    }
}
