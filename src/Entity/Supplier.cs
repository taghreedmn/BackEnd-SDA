using System.ComponentModel.DataAnnotations;

namespace FusionTech.src.Entity
{
    public class Supplier
    {
        public Guid SupplierId { get; set; }

        [StringLength(
            100,
            MinimumLength = 3,
            ErrorMessage = "Name must be between 3 and 100 characters"
        )]
        public string? SupplierName { get; set; }

        public string? SupplierContact { get; set; }

        public string? SupplierBankInfo { get; set; }

        
   } 

}
