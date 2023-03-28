namespace Domain.Entities
{
    /// <summary>
    /// Represents a promotion or special offer made by a vendor or the farmer's market.
    /// </summary>
    public sealed class Promotion
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }

    }
}
