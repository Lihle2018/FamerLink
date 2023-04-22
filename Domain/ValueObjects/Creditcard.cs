namespace Domain.ValueObjects
{
    [Serializable]
    [Owned]
    public class CreditCard : ValueObject<CreditCard>
    {

        public string CardNumber { get; }
        public string CardholderName { get; }
        public int ExpirationMonth { get; }
        public int ExpirationYear { get; }
        public string CVV { get; }

        public CreditCard(string cardNumber, string cardholderName, int expirationMonth, int expirationYear, string cvv)
        {
            CardNumber = cardNumber;
            CardholderName = cardholderName;
            ExpirationMonth = expirationMonth;
            ExpirationYear = expirationYear;
            CVV = cvv;
        }
        public CreditCard()
        {
            // Empty constructor needed for EF Core to work properly
        }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return CardNumber;
            yield return CardholderName;
            yield return ExpirationMonth;
            yield return ExpirationYear;
            yield return CVV;
        }
    }

}
