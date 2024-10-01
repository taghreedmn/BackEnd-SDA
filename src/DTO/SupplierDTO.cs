namespace FusionTech.src.DTO
{
    public class SupplierDTO
    {
        public class SupplierCreateDto
        {
            public String SupplierName { get; set; }
            public String SupplierContact { get; set; }
            public String SupplierBankInfo { get; set; }
        }

        public class SupplierReadDto
        {
            public Guid SupplierId { get; set; }
            public String SupplierName { get; set; }
            public String SupplierContact { get; set; }
            public String SupplierBankInfo { get; set; }
        }

        public class SupplierUpdateDto
        {
            public String SupplierName { get; set; }
            public String SupplierContact { get; set; }
            public String SupplierBankInfo { get; set; }
        }
    }
}
