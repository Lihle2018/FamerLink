using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Layout;
using iText.Kernel.Colors;

namespace Domain.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IVendorRepository _vendorRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly IPaymentRepository _paymentRepository;

        public InvoiceService(IOrderRepository orderRepository, IVendorRepository vendorRepository,
            ICustomerRepository customerRepository, IPaymentRepository paymentRepository)
        {
            _orderRepository = orderRepository;
            _vendorRepository = vendorRepository;
            _customerRepository = customerRepository;
            _paymentRepository = paymentRepository;
        }

        public byte[] GenerateInvoicePdf(int orderId)
        {
            var order = _orderRepository.GetById(orderId);
            var vendor = _vendorRepository.GetById(order.VendorId);
            var customer = _customerRepository.GetById(order.Customer.Id);
            var payment = _paymentRepository.GetByOrderId(orderId);

            var invoice = new Invoice
            {
                CompanyLogo = "FarmLink Logo", // Replace with actual logo
                VendorName = vendor.Name,
                VendorAddress = $"{vendor.Location.Address}, {vendor.Location}",
                CustomerName = $"{customer.Name} {customer.LastName}",
                CustomerAddress = $"{customer.Location.Address}, {customer.Location}",
                OrderDate = order.CreatedAt,
                OrderNumber = order.Id,
                PaymentMethod = order.PaymentMethod.Name,
                PaymentDate = order.CreatedAt,
                AmountPaid = payment.Amount,
                OrderItems = order.Items.ToList(),
            };

            var writer = new MemoryStream();
            var pdfWriter = new PdfWriter(writer);
            var pdfDocument = new PdfDocument(pdfWriter);
            var document = new Document(pdfDocument);

            // Set document properties
            document.SetProperty(Property.ROWSPAN, true);
            document.SetProperty(Property.LEADING, new Leading(Leading.MULTIPLIED, 1.2f));
            document.SetMargins(36, 36, 36, 36);

            // Add header
            var header = new Paragraph(invoice.CompanyLogo)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(24f)
                .SetFontColor(ColorConstants.DARK_GRAY);
            document.Add(header);

            // Add vendor and customer details
            var vendorTable = new Table(UnitValue.CreatePercentArray(new float[] { 1, 3 }))
                .UseAllAvailableWidth();
            vendorTable.AddCell(new Cell().Add(new Paragraph("Vendor Name:")));
            vendorTable.AddCell(new Cell().Add(new Paragraph(invoice.VendorName)));
            vendorTable.AddCell(new Cell().Add(new Paragraph("Vendor Address:")));
            vendorTable.AddCell(new Cell().Add(new Paragraph(invoice.VendorAddress)));
            document.Add(vendorTable);
            // Add order details
            var orderTable = new Table(UnitValue.CreatePercentArray(new float[] { 1, 1, 1, 1 }))
                .UseAllAvailableWidth();
            orderTable.AddHeaderCell(new Cell().Add(new Paragraph("Item Name")));
            orderTable.AddHeaderCell(new Cell().Add(new Paragraph("Quantity")));
            orderTable.AddHeaderCell(new Cell().Add(new Paragraph("Price")));
            orderTable.AddHeaderCell(new Cell().Add(new Paragraph("Total")));

            foreach (var item in invoice.OrderItems)
            {
                orderTable.AddCell(new Cell().Add(new Paragraph(item.Product.Name)));
                orderTable.AddCell(new Cell().Add(new Paragraph(item.Quantity.ToString())));
                orderTable.AddCell(new Cell().Add(new Paragraph(item.Product.Price.ToString())));
                orderTable.AddCell(new Cell().Add(new Paragraph((item.Quantity * item.Product.Price).ToString())));
            }

            document.Add(orderTable);

            // Add payment details
            var paymentTable = new Table(UnitValue.CreatePercentArray(new float[] { 1, 3 }))
                .UseAllAvailableWidth();
            paymentTable.AddCell(new Cell().Add(new Paragraph("Payment Method:")));
            paymentTable.AddCell(new Cell().Add(new Paragraph(invoice.PaymentMethod)));
            paymentTable.AddCell(new Cell().Add(new Paragraph("Payment Date:")));
            paymentTable.AddCell(new Cell().Add(new Paragraph(invoice.PaymentDate.ToString())));
            paymentTable.AddCell(new Cell().Add(new Paragraph("Amount Paid:")));
            paymentTable.AddCell(new Cell().Add(new Paragraph(invoice.AmountPaid.ToString())));
            document.Add(paymentTable);

            document.Close();
            var pdfBytes = writer.ToArray();
            return pdfBytes;
        }
    } 
 }
