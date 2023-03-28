using Domain.ValueObjects;

namespace Domain.Entities
{
    /// <summary>
    /// Represents a vendor who sells products at the farmer's market.
    /// </summary>
    public class Vendor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Location Location { get; set; }
        public ContactInfo ContactInfo { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<VendorTag> VendorTags { get; set; }
        public Money MinimumOrderAmount { get; set; }
        public bool AcceptsCreditCard { get; set; }
    }

}
