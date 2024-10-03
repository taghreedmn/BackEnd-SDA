using System.ComponentModel.DataAnnotations;

namespace FusionTech.src.Entity
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; }
        public required string CategoryName { get; set; }
    }
}
