namespace Domain.Entities
{
    /// <summary>
    /// Represents a payment made by a customer for an order.
    /// </summary>
    public sealed class Payment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
    }

    public enum PaymentStatus
    {
        Pending,
        Authorized,
        Paid,
        Failed
    }

}
