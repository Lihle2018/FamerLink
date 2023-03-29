namespace Domain.Interfaces.Services
{
    public interface IInvoiceService
    {
        byte[] GenerateInvoicePdf(int orderId);
    }
}
