using System.ComponentModel.DataAnnotations;

namespace FusionTech.src.Entity
{
    public class Category
    {
        public Guid Id { get; set; }

        [Required]
        public required string CategoryName { get; set; }
    }
}
