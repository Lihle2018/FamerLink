using Domain.ValueObjects;

namespace Domain.Entities
{
    /// <summary>
    /// Represents an order placed by a customer for one or more products from one or more vendors.
    /// </summary>
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public ICollection<OrderItem> Items { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public OrderStatus Status { get; set; }
        public Money TotalAmount { get; set; }
        public Money TaxAmount { get; set; }
        public Money DeliveryFee { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string PaymentTransactionId { get; set; }
        public string DeliveryNote { get; set; }
        public DeliveryWindow DeliveryWindow { get; set; }
        public string CancellationReason { get; set; }
        public Money RefundAmount { get; set; }
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }
    }


    public enum OrderStatus
    {
        Pending,
        Confirmed,
        Shipped,
        Delivered,
        Cancelled
    }

}
