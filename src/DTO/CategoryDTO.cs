using System.ComponentModel.DataAnnotations;

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

        public class CategoryReadDto
        {
            public Guid CategoryId { get; set; }

            public string? CategoryName { get; set; }
        }

        public class CategoryUpdateDto
        {
            [StringLength(100, ErrorMessage = "Category name cannot exceed 100 characters.")]
            public string? CategoryName { get; set; }
        }
    }
}
