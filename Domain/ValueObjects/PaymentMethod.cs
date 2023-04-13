

namespace Domain.ValueObjects
{
    public class PaymentMethod : ValueObject<PaymentMethod>
    {
        public string Name { get; }
        public CreditCard CreditCard { get; }
        public BankAccount BankAccount { get; }

        public PaymentMethod(string name, CreditCard creditCard = null, BankAccount bankAccount = null)
        {
            Name = name;
            CreditCard = creditCard;
            BankAccount = bankAccount;
        }
        public PaymentMethod()
        {
            // Empty constructor needed for EF Core to work properly
        }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Name;
            yield return CreditCard;
            yield return BankAccount;
        }
    }
}
