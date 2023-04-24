namespace Domain.Entities
{
    /// <summary>
    /// represents a person who has an account on the app and can use it to perform various actions, such as making purchases, managing their account settings, and possibly also selling products as a vendor.
    /// </summary>
    public sealed class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public List<Order> Orders { get; set; }
    }
}
