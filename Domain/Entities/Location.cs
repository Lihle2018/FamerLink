using Domain.ValueObjects;
namespace Domain.Entities
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public GeoLocation GeoLocation { get; set; }
        public ICollection<Vendor> Vendors { get; set; }
    }
}
