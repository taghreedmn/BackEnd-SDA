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
        public async Task<ActionResult<CategoryDTO.CategoryBasicDto>> CreateOne([FromBody] CategoryCreateDto createDto)
        {
            var categoryCreated = await _categoryService.CreateOneAsync(createDto);
            return CreatedAtAction(nameof(GetByIdAsync), new { id = categoryCreated.CategoryId }, categoryCreated);
        }

        [HttpGet]
        public async Task<ActionResult<CategoryDTO.CategoryListDto>> GetAllAsync([FromQuery] PaginationOptions paginationOptions)
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
       public async Task<ActionResult<CategoryListDto>> GetCategoryDetailsByNameAsync(
        [FromRoute] string categoryName, 
        [FromQuery] PaginationOptions paginationOptions)
       {
           var (categoryDetails, totalCount) = await _categoryService.GetCategoryDetailsByNameAsync(categoryName, paginationOptions);

           var response = new CategoryListDto
          {
             Categories = categoryDetails.Select(cd => new CategoryDTO.CategoryBasicDto
             {
                 CategoryId = cd.CategoryId,
                 CategoryName = cd.CategoryName,
             }).ToList(),
                 TotalCategory = totalCount
         };

    return Ok(response);
}

        [Authorize(Policy = "admin")]
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteOne([FromRoute] Guid id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound(); 
            }

            await _categoryService.DeleteOneAsync(category.CategoryId);
            return NoContent();
        }

        [Authorize(Policy = "admin")]
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateCategory(Guid id, [FromBody] CategoryUpdateDto updateDto)
        {
            var updated = await _categoryService.UpdateOneAsync(id, updateDto);
            if (!updated)
            {
                return NotFound(); 
            }

            return NoContent();
        }

        [HttpGet("{id}", Name = "GetByIdAsync")]
        public async Task<ActionResult<CategoryDTO.CategoryDetailedDto>> GetByIdAsync(Guid id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }
    }
}
