using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using NutriHub.Domain.Entities;
using iText.Kernel.Colors;
using iText.Layout.Borders;
using NutriHub.Application.Abstractions.Services;

namespace NutriHub.Persistence.Services
{

    public class PdfService : IPdfService
    {
        public byte[] GenerateOrderReceipt(Order order, List<OrderItem> orderItems, User user)
        {
            using (var memoryStream = new MemoryStream())
            {
                var writer = new PdfWriter(memoryStream);
                var pdf = new PdfDocument(writer);
                var document = new Document(pdf);

                // Şirket Bilgileri
                var companyTable = new Table(1).UseAllAvailableWidth();
                companyTable.AddCell(CreateCell("[NutriHub]", 14, true, TextAlignment.LEFT));
                companyTable.AddCell(CreateCell("[Street Address]", 12, false, TextAlignment.LEFT));
                companyTable.AddCell(CreateCell("[Istanbul, ST ZIP]", 12, false, TextAlignment.LEFT));
                companyTable.AddCell(CreateCell("Phone: (900) 212-2237", 12, false, TextAlignment.LEFT));
                companyTable.AddCell(CreateCell("Fax: (000) 000-0000", 12, false, TextAlignment.LEFT));
                companyTable.AddCell(CreateCell("Website: www.nutrihub.com", 12, false, TextAlignment.LEFT));
                document.Add(companyTable);

                // Satır içi boşluk
                document.Add(new Paragraph("\n"));

                // Sipariş Bilgileri
                var orderInfoTable = new Table(2).UseAllAvailableWidth();
                orderInfoTable.AddCell(CreateCell("PURCHASE ORDER", 16, true, TextAlignment.RIGHT, 2));
                orderInfoTable.AddCell(CreateCell("DATE", 12, true, TextAlignment.LEFT));
                orderInfoTable.AddCell(CreateCell(DateTime.Now.ToString("MM/dd/yyyy"), 12, false, TextAlignment.LEFT));
                orderInfoTable.AddCell(CreateCell("PO #", 12, true, TextAlignment.LEFT));
                orderInfoTable.AddCell(CreateCell(order.OrderCode, 12, false, TextAlignment.LEFT));
                document.Add(orderInfoTable);

                // Satır içi boşluk
                document.Add(new Paragraph("\n"));

                // Vendor ve Ship To Bilgileri
                var vendorShipTable = new Table(2).UseAllAvailableWidth();
                vendorShipTable.AddCell(CreateCell("VENDOR", 12, true, TextAlignment.CENTER));
                vendorShipTable.AddCell(CreateCell("SHIP TO", 12, true, TextAlignment.CENTER));
                vendorShipTable.AddCell(CreateCell("[Company Name]\n[Contact or Department]\n[Street Address]\n[City, ST ZIP]\nPhone: (000) 000-0000\nFax: (000) 000-0000", 12, false, TextAlignment.LEFT));
                vendorShipTable.AddCell(CreateCell($"{order.Address.Name} {order.Address.Surname} \n{order.Address.Province}/{order.Address.District}\nPhone: {order.Address.Phone}", 12, false, TextAlignment.LEFT));
                document.Add(vendorShipTable);

                // Satır içi boşluk
                document.Add(new Paragraph("\n"));

                // Ürün Tablosu
                var productTable = new Table(new float[] { 1, 3, 1, 1, 1 }).UseAllAvailableWidth();
                productTable.AddHeaderCell(CreateCell("ITEM #", 12, true, TextAlignment.CENTER));
                productTable.AddHeaderCell(CreateCell("DESCRIPTION", 12, true, TextAlignment.CENTER));
                productTable.AddHeaderCell(CreateCell("QTY", 12, true, TextAlignment.CENTER));
                productTable.AddHeaderCell(CreateCell("UNIT PRICE", 12, true, TextAlignment.CENTER));
                productTable.AddHeaderCell(CreateCell("TOTAL", 12, true, TextAlignment.CENTER));

                foreach (var item in orderItems)
                {
                    productTable.AddCell(CreateCell(item.ProductId.ToString(), 12, false, TextAlignment.CENTER));
                    productTable.AddCell(CreateCell(item.Product.Name, 12, false, TextAlignment.LEFT));
                    productTable.AddCell(CreateCell(item.Quantity.ToString(), 12, false, TextAlignment.CENTER));
                    productTable.AddCell(CreateCell(item.Product.Price.ToString("C"), 12, false, TextAlignment.RIGHT));
                    productTable.AddCell(CreateCell((item.Quantity * item.Product.Price).ToString("C"), 12, false, TextAlignment.RIGHT));
                }

                document.Add(productTable);

                // Satır içi boşluk
                document.Add(new Paragraph("\n"));

                // Toplamlar
                var totalsTable = new Table(2).UseAllAvailableWidth();
                totalsTable.AddCell(CreateCell("ARA TOPLAM", 12, true, TextAlignment.RIGHT));
                totalsTable.AddCell(CreateCell(order.Amount.ToString("C"), 12, false, TextAlignment.RIGHT));
                totalsTable.AddCell(CreateCell("ÖDEME METODU FİYATI", 12, true, TextAlignment.RIGHT));
                totalsTable.AddCell(CreateCell(order.PaymentMethodDiscount.ToString("C"), 12, false, TextAlignment.RIGHT)); // Vergi hesaplanmamış örnek
                totalsTable.AddCell(CreateCell("KUPON İNDİRİMİ", 12, true, TextAlignment.RIGHT));
                totalsTable.AddCell(CreateCell(order.CouponDiscount.ToString("C"), 12, false, TextAlignment.RIGHT)); // Kargo hesaplanmamış örnek
                totalsTable.AddCell(CreateCell("ÜYELİK İNDİRİMİ", 12, true, TextAlignment.RIGHT));
                totalsTable.AddCell(CreateCell(order.Amount.ToString("C"), 12, false, TextAlignment.RIGHT)); // Diğer hesaplanmamış örnek
                totalsTable.AddCell(CreateCell("TOTAL", 12, true, TextAlignment.RIGHT));
                totalsTable.AddCell(CreateCell(order.Amount.ToString("C"), 12, false, TextAlignment.RIGHT));
                document.Add(totalsTable);

                // Yorumlar
                document.Add(new Paragraph("Comments or Special Instructions")
                    .SetFontSize(12)
                    .SetBold()
                    .SetBackgroundColor(ColorConstants.LIGHT_GRAY));
                document.Add(new Paragraph(order.Note));

                document.Close();
                return memoryStream.ToArray();
            }
        }

        private Cell CreateCell(string content, int fontSize, bool isBold, TextAlignment alignment, int colSpan = 1)
        {
            var cell = new Cell(1, colSpan).Add(new Paragraph(content).SetFontSize(fontSize));
            if (isBold)
            {
                cell.SetBold();
            }
            cell.SetTextAlignment(alignment);
            cell.SetBorder(Border.NO_BORDER);
            return cell;
        }
    }
}
