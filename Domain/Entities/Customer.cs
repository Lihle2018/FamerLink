namespace Domain.Entities
{
    /// <summary>
    /// Represents a customer who purchases products from vendors at the farmer's market.
    /// </summary>
    public sealed class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int LocationId { get; set; }
       public Location Location { get; set; }   
        public ICollection<Order> Orders { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
