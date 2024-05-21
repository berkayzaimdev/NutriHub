using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using NutriHub.Domain.Entities;
using iText.Kernel.Colors;
using iText.Layout.Borders;
using NutriHub.Application.Abstractions.Services;
using System.Drawing.Text;
using Microsoft.AspNetCore.Identity;
using iText.IO.Font;
using iText.Kernel.Font;

namespace NutriHub.Persistence.Services
{
    public class PdfService : IPdfService
    {
        private PdfFont font;

        public byte[] GenerateOrderReceipt(Order order)
        {
            using (var memoryStream = new MemoryStream())
            {
                var writer = new PdfWriter(memoryStream);
                var pdf = new PdfDocument(writer);
                var document = new Document(pdf);
                var fontPath = Path.Combine("wwwroot", "fonts", "calibri.ttf");
                font = PdfFontFactory.CreateFont(fontPath, PdfEncodings.IDENTITY_H);

                // Şirket Bilgileri
                var companyTable = new Table(1).UseAllAvailableWidth();
                companyTable.AddCell(CreateCell("NutriHub Vitamin ve Gıda Takviyeleri Paz. Tic. A.Ş.", 14, true, TextAlignment.LEFT));
                companyTable.AddCell(CreateCell("Başıbüyük, Süreyyapaşa Başıbüyük Yolu Sk No:6", 12, false, TextAlignment.LEFT));
                companyTable.AddCell(CreateCell("Maltepe/İstanbul, 34854", 12, false, TextAlignment.LEFT));
                companyTable.AddCell(CreateCell("Telefon: (900) 212-2237", 12, false, TextAlignment.LEFT));
                companyTable.AddCell(CreateCell("Faks: (900) 212-2237", 12, false, TextAlignment.LEFT));
                companyTable.AddCell(CreateCell("Website: www.nutrihub.com", 12, false, TextAlignment.LEFT));
                document.Add(companyTable);

                // Satır içi boşluk
                document.Add(new Paragraph("\n"));

                // Sipariş Bilgileri
                var orderInfoTable = new Table(2).UseAllAvailableWidth();
                orderInfoTable.AddCell(CreateCell("SİPARİŞ BİLGİSİ", 16, true, TextAlignment.CENTER, 2));
                orderInfoTable.AddCell(CreateCell("TARİH", 12, true, TextAlignment.LEFT));
                orderInfoTable.AddCell(CreateCell(DateTime.Now.ToString("MM/dd/yyyy"), 12, false, TextAlignment.LEFT));
                orderInfoTable.AddCell(CreateCell("SİPARİŞ KODU #", 12, true, TextAlignment.LEFT));
                orderInfoTable.AddCell(CreateCell(order.OrderCode, 12, false, TextAlignment.LEFT));
                document.Add(orderInfoTable);

                // Satır içi boşluk
                document.Add(new Paragraph("\n"));

                // Vendor ve Ship To Bilgileri
                var vendorShipTable = new Table(1).UseAllAvailableWidth();
                vendorShipTable.AddCell(CreateCell("TESLİMAT BİLGİLERİ", 12, true, TextAlignment.CENTER));
                vendorShipTable.AddCell(CreateCell($"{order.Address.Name} {order.Address.Surname} \n{order.Address.Province}/{order.Address.District}\nTelefon: {order.Address.Phone}", 12, false, TextAlignment.LEFT));
                document.Add(vendorShipTable);

                // Satır içi boşluk
                document.Add(new Paragraph("\n"));

                // Ürün Tablosu
                var productTable = new Table(new float[] { 1, 3, 1, 1, 1 }).UseAllAvailableWidth();
                productTable.AddHeaderCell(CreateCell("ÜRÜN #", 12, true, TextAlignment.CENTER));
                productTable.AddHeaderCell(CreateCell("ÜRÜN AD", 12, true, TextAlignment.CENTER));
                productTable.AddHeaderCell(CreateCell("MİKTAR", 12, true, TextAlignment.CENTER));
                productTable.AddHeaderCell(CreateCell("BİRİM FİYAT", 12, true, TextAlignment.CENTER));
                productTable.AddHeaderCell(CreateCell("TOPLAM", 12, true, TextAlignment.CENTER));

                foreach (var item in order.OrderItems)
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
                totalsTable.AddCell(CreateCell(order.PaymentMethodDiscount.ToString("C"), 12, false, TextAlignment.RIGHT));
                totalsTable.AddCell(CreateCell("KUPON İNDİRİMİ", 12, true, TextAlignment.RIGHT));
                totalsTable.AddCell(CreateCell(order.CouponDiscount.ToString("C"), 12, false, TextAlignment.RIGHT));
                totalsTable.AddCell(CreateCell("ÜYELİK İNDİRİMİ", 12, true, TextAlignment.RIGHT));
                totalsTable.AddCell(CreateCell(order.MembershipDiscount.ToString("C"), 12, false, TextAlignment.RIGHT));
                totalsTable.AddCell(CreateCell("TOPLAM TUTAR", 12, true, TextAlignment.RIGHT));
                totalsTable.AddCell(CreateCell(order.Amount.ToString("C"), 12, false, TextAlignment.RIGHT));
                document.Add(totalsTable);

                // Yorumlar
                document.Add(new Paragraph("Sipariş Notu")
                    .SetFontSize(12)
                    .SetBold()
                    .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                    .SetFont(font));
                document.Add(new Paragraph(order.Note).SetFont(font));

                document.Close();
                return memoryStream.ToArray();
            }
        }

        private Cell CreateCell(string content, int fontSize, bool isBold, TextAlignment alignment, int colSpan = 1)
        {
            var cell = new Cell(1, colSpan).Add(new Paragraph(content).SetFontSize(fontSize).SetFont(font));
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
