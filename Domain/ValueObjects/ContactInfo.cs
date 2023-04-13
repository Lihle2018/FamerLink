namespace Domain.ValueObjects
{
    [Serializable]
    public class ContactInfo : ValueObject<ContactInfo>
    {
        public string Email { get; private set; }
        public string Phone { get; private set; }

        protected ContactInfo() { }

        public ContactInfo(string email, string phone)
        {
            Email = email;
            Phone = phone;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Email;
            yield return Phone;
        }
    }
}
