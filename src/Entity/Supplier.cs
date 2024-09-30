using System.ComponentModel.DataAnnotations;

namespace FusionTech.src.Entity
{
    public class Supplier
    {
        public Guid SupplierId { get; set; }

        [Required(ErrorMessage = "Supplier name is required.")]
        [StringLength(100, ErrorMessage = "Supplier name cannot exceed 100 characters.")]
        public string SupplierName { get; set; }

        [Required(ErrorMessage = "Supplier contact is required.")]
        [StringLength(50, ErrorMessage = "Supplier contact cannot exceed 50 characters.")]
        [RegularExpression(@"^[0-9\-\(\)\s]+$", ErrorMessage = "Supplier contact can only contain numbers, dashes, parentheses, and spaces.")]
        public string SupplierContact { get; set; }

        [StringLength(200, ErrorMessage = "Supplier bank information cannot exceed 200 characters.")]
        public string SupplierBankInfo { get; set; }
    }
}
