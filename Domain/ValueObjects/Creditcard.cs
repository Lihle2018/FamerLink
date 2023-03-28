using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domain.ValueObjects
{
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
