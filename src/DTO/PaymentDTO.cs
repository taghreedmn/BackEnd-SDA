namespace FusionTech.src.DTO
{
    public class PaymentDTO
    {
        public class PaymentCreateDto
        {
            public string? PaymentMethod { get; set; }
        }
        // read data = get data
        public class PaymentReadDto
        {
            public Guid Id { get; set; }
            public string? PaymentMethod { get; set; }
        }
        // update
        public class PaymentUpdateDto
        {
            public string? PaymentMethod { get; set; }

        }

    }
}