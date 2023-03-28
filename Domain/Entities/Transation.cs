using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    /// <summary>
    /// the Transaction class represents a financial transaction that has occurred within the system, which could include payments, refunds, or other financial events. The Transaction class is more generic and could be used to represent a wider range of financial events beyond just payments.
    /// </summary>
    public sealed class Transaction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public decimal Amount { get; set; }
        public int CustomerId { get; set; }
        public int VendorId { get; set; }
    }
}
