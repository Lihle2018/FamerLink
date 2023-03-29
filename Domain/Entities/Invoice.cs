using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [NotMapped]
    public class Invoice
    {
        public string CompanyLogo { get; set; }
        public string VendorName { get; set; }
        public string VendorAddress { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public object OrderDate { get; set; }
        public int OrderNumber { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal AmountPaid { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}