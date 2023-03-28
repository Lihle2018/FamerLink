namespace Domain.Entities
{
    /// <summary>
    /// Represents a product that can be sold at a farmer's market, such as fruits, vegetables, eggs, or meat.
    /// </summary>
    public sealed class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }
    }
}
