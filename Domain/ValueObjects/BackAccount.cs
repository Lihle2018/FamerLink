
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
        public BankAccount()
        {
            // Empty constructor needed for EF Core to work properly
        }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return AccountNumber;
            yield return RoutingNumber;
        }
    }






}
