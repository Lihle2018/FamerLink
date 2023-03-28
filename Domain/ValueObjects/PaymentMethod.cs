

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

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Name;
            yield return CreditCard;
            yield return BankAccount;
        }
    }
}
