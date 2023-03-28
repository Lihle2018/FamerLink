namespace Domain.Entities
{
/// <summary>
/// Represents a review left by a customer for a vendor or product.
/// </summary>
    public sealed class Review
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
    }
}
