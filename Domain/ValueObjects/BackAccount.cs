
namespace Domain.ValueObjects
{
    [Serializable]
    public class BankAccount : ValueObject<BankAccount>
    {
        public string AccountNumber { get; }
        public string RoutingNumber { get; }

        public BankAccount(string accountNumber, string routingNumber)
        {
            AccountNumber = accountNumber;
            RoutingNumber = routingNumber;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return AccountNumber;
            yield return RoutingNumber;
        }
    }






}
