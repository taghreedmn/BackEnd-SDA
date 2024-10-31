
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
        public async Task<ActionResult<CategoryBasicDto>> CreateOne([FromBody] CategoryCreateDto createDto)
        {
            var categoryCreated = await _categoryService.CreateOneAsync(createDto);
            return Created($"api/v1/categories/{categoryCreated.CategoryId}", categoryCreated);
        }
        
        [HttpGet]
        public async Task<ActionResult<CategoryListDto>> GetAllAsync(
           [FromQuery] PaginationOptions paginationOptions)
        {
           var categoryList = await _categoryService.GetAllAsync(paginationOptions);
           var totalCategory = await _categoryService.CountCategoryAsync();

           var categoriesDto = categoryList.Select(c => new CategoryDTO.CategoryBasicDto
           {
              CategoryId = c.CategoryId,
              CategoryName = c.CategoryName,
            }).ToList();

          var response = new CategoryDTO.CategoryListDto
          {
                  Categories = categoriesDto,
                  TotalCategory = totalCategory
          };

              return Ok(response);
          }


        [HttpGet("{categoryName}")]
        public async Task<ActionResult<List<CategoryDetailedDto>>> GetCategoryDetailsByNameAsync([FromRoute] string categoryName)
        {
            var category = await _categoryService.GetCategoryDetailsByNameAsync(categoryName);
            return Ok(category);
        }

        [Authorize(Policy = "admin")]
        [HttpDelete("{id}")]
        public async Task<ActionResult<CategoryBasicDto>> DeleteOne([FromRoute] Guid id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound(); // Handle not found scenario
            }

            await _categoryService.DeleteOneAsync(category.CategoryId);
            return Ok(category);
        }

        [Authorize(Policy = "admin")]
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateCategory(Guid id, CategoryUpdateDto updateDto)
        {
            var updatedCategory = await _categoryService.UpdateOneAsync(id, updateDto);
            if (updatedCategory == null)
            {
                return NotFound(); // Handle not found scenario
            }

            return NoContent();
        }
    }
}