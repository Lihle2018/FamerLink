namespace Domain.ValueObjects
{
    [Serializable]
    [Owned]
    
    public class Money : ValueObject<Money>
    {
        private Money(decimal amount, Currency currency)
        {
            Amount = amount;
            Currency = currency;
        }
        public Money()
        {
            // Empty constructor needed for EF Core to work properly
        }
        public decimal Amount { get; }
        public Currency Currency { get; }

        public static Money FromDecimal(decimal amount, string currencyCode)
        {
            var currency = Currency.GetByCode(currencyCode);
            return new Money(amount, currency);
        }

        public static Money operator +(Money a, Money b)
        {
            if (a.Currency != b.Currency)
            {
                throw new ArgumentException("Cannot add amounts with different currencies.");
            }

            var amount = a.Amount + b.Amount;
            return new Money(amount, a.Currency);
        }

        public static Money operator -(Money a, Money b)
        {
            if (a.Currency != b.Currency)
            {
                throw new ArgumentException("Cannot subtract amounts with different currencies.");
            }

            var amount = a.Amount - b.Amount;
            return new Money(amount, a.Currency);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Amount;
            yield return Currency;
        }

        public override string ToString()
        {
            return $"{Amount} {Currency}";
        }
    }

}
