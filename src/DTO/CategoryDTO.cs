namespace FusionTech.src.DTO
{
    public class CategoryDTO
    {
        public class CategoryCreateDto
        {
            [Required(ErrorMessage = "Category name is required.")]
            [StringLength(100, ErrorMessage = "Category name cannot exceed 100 characters.")]
            public string? CategoryName { get; set; }
        }

        // This DTO represents individual category data
        public class CategoryBasicDto 
        {
            public Guid CategoryId { get; set; }
            public string? CategoryName { get; set; }
        }

        // This DTO represents the response that contains a list of categories
        public class CategoryListDto 
        {
            public List<CategoryBasicDto> Categories { get; set; } = new List<CategoryBasicDto>();
            public int TotalCategory { get; set; }
        }

        public class CategoryDetailedDto
        {
            public Guid CategoryId { get; set; }
            public string? CategoryName { get; set; }
            public ICollection<VideoGameInfoReadDto> VideoGameInfos { get; set; }
        }

        public class CategoryUpdateDto
        {
            [StringLength(100, ErrorMessage = "Category name cannot exceed 100 characters.")]
            public string? CategoryName { get; set; }
        }
    }
}
