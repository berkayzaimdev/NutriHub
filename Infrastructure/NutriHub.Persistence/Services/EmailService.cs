using NutriHub.Application.Abstractions.Services;
using NutriHub.Application.Helpers;
using System.Globalization;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading;

namespace NutriHub.Persistence.Services
{
    public class EmailService : IEmailService
    {
        private readonly SmtpClient _smtpClient;

        public EmailService(SmtpClient smtpClient)
        {
            _smtpClient = smtpClient;
        }

        public async Task SendConfirmationMailAsync(string to, string verificationLink)
        {
            var content = $"Lütfen email adresinizi doğrulamak için aşağıdaki bağlantıya tıklayın:\n\n{verificationLink}";
            var body = EmailHelper.GetBody(content);

            var mailMessage = new MailMessage(EmailHelper.Sender, "nutrihubuser@outlook.com.tr")
            {
                Subject = "NutriHub - Email Doğrulama",
                Body = body,
                IsBodyHtml = true
            };

            await _smtpClient.SendMailAsync(mailMessage);
        }

        public async Task SendRankUpEmailAsync(string to, string newRank)
        {
            var content = $"Tebrikler! Son alışverişiniz ile birlikte rütbe atladınız.\nYeni rütbeniz: <b>{newRank}</b>";
            var body = EmailHelper.GetBody(content);

            var mailMessage = new MailMessage(EmailHelper.Sender, to)
            {
                Subject = "NutriHub - Rütbe Atlama",
                Body = body,
                IsBodyHtml = true
            };

            await _smtpClient.SendMailAsync(mailMessage);
        }

        public async Task SendOrderReceiptEmailAsync(string fullName, string to, byte[] pdfReceipt)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("tr-TR");
            var content = $"<b>Sayın {fullName},\n{DateTime.Now.ToShortDateString}</b> tarihinde oluşturulan e-faturanıza ekteki dosyadan ulaşabilirsiniz.";
            var body = EmailHelper.GetBody(content);

            var mailMessage = new MailMessage(EmailHelper.Sender, to)
            {
                Subject = "NutriHub e-Arşiv Faturası",
                Body = body,
                IsBodyHtml = true
            };

            var attachment = new Attachment(new MemoryStream(pdfReceipt), "e-fatura.pdf", MediaTypeNames.Application.Pdf);
            mailMessage.Attachments.Add(attachment);

            await _smtpClient.SendMailAsync(mailMessage);
        }
    }
}
