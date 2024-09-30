using System.ComponentModel.DataAnnotations;

namespace FusionTech.src.Entity
{
    public class Category
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Category name is required")]
        public string CategoryName { get; set; }

    }
}