using System;
using System.ComponentModel.DataAnnotations;

namespace FusionTech.src.Entity
{
    public class Supplier
   {
       public Guid SupplierId { get; set; } 

       [Required(ErrorMessage = "Name is required")]
       [StringLength(100, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 100 characters")]
       public string SupplierName { get; set; }

       [Required(ErrorMessage = "Contact is required")]
        public string SupplierContact { get; set; }

       [Required(ErrorMessage = "Bank information is required")]
        public string SupplierBankInfo { get; set; }

         public string SupplierPicturePath { get; set; }
   } 
}

