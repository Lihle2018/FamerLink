namespace Domain.ValueObjects
{
    /// <summary>
    /// Note that the Currency class has a private constructor to ensure that instances can only be created through the GetByCode method, which enforces that the code is always in upper case. This helps to ensure consistency in the application. The class also overrides the ToString method so that it returns the currency code as a string.
    /// </summary>
    public class Currency : ValueObject<Currency>
    {
        private Currency(string code)
        {
            Code = code;
        }

        public string Code { get; }

        public static Currency USD => new Currency("USD");
        public static Currency CAD => new Currency("CAD");
        public static Currency EUR => new Currency("EUR");
        public static Currency GBP => new Currency("GBP");

        public static Currency GetByCode(string code)
        {
            // You may want to add additional validation here to ensure that the code is valid.
            return new Currency(code.ToUpperInvariant());
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Code;
        }

        public override string ToString()
        {
            return Code;
        }
    }

}
