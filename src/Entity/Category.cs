using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FusionTech.src.Entity
{
    public class Category
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Category name is required.")]
        // [DisplayName("Category name")]
        [StringLength(30, ErrorMessage = "Category name cannot exceed 30 characters.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Category name can only contain letters and spaces.")]
        public string CategoryName { get; set; }
    }
}

