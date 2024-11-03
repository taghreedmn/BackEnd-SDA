namespace FusionTech.src.DTO
{
    public class CategoryDTO
    {
        public class CategoryCreateDto
        {
            [Required(ErrorMessage = "Category name is required.")]
            [StringLength(100, ErrorMessage = "Category name cannot exceed 100 characters.")]
            public string CategoryName { get; set; } = string.Empty;
        }

        public class CategoryBasicDto 
        {
            public Guid CategoryId { get; set; }
            public string CategoryName { get; set; } = string.Empty;
        }

        public class CategoryListDto 
        {
            public List<CategoryDetailedDto> Categories { get; set; } = new List<CategoryDetailedDto>();
            public int TotalCategory { get; set; }
        }

        public class CategoryDetailedDto
        {
            public Guid CategoryId { get; set; }
            public string CategoryName { get; set; } = string.Empty;
            public ICollection<VideoGameInfoReadDto> VideoGameInfos { get; set; } = new List<VideoGameInfoReadDto>();
        }

        public class CategoryUpdateDto
        {
            [StringLength(100, ErrorMessage = "Category name cannot exceed 100 characters.")]
            public string? CategoryName { get; set; }
        }
    }
}