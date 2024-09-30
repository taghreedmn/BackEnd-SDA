namespace  FusionTech.src.Entity
 {
    public class Order 
    {
        public Guid OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public float TotalPrice { get; set; }
        public Guid PaymentId { get; set; }
        public Guid StoreId { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid CustomerId { get; set; } 
    }
}
