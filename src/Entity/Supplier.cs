using System.ComponentModel.DataAnnotations;

namespace FusionTech.src.Entity
{

   public class Supplier
   {

      public Guid SupplierId { get; set; }
      public string? SupplierName { get; set; }

      public string? SupplierBankInfo { get; set; }
      public string SupplierContactInfo { get; internal set; }
    }

}
