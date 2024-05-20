using NutriHub.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

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
            var mailMessage = new MailMessage("no-reply@yourdomain.com", to)
            {
                Subject = "NutriHub - Email Doğrulama",
                Body = $"Lütfen email adresinizi doğrulamak için aşağıdaki bağlantıya tıklayın:\n\n{verificationLink}",
                IsBodyHtml = false
            };

            await _smtpClient.SendMailAsync(mailMessage);
        }

        public async Task SendRankUpEmailAsync(string to, string newRank)
        {
            var mailMessage = new MailMessage("no-reply@yourdomain.com", to)
            {
                Subject = "NutriHub - Rütbe Atlama",
                Body = $"Tebrikler! Yeni rütbeniz: {newRank}"
            };

            await _smtpClient.SendMailAsync(mailMessage);
        }

        public async Task SendOrderReceiptEmailAsync(string to, byte[] pdfReceipt)
        {
            var mailMessage = new MailMessage("no-reply@yourdomain.com", to)
            {
                Subject = "NutriHub - {orderCode} kodlu siparişiniz",
                Body = "Siparişinizin makbuzu ektedir."
            };

            var attachment = new Attachment(new MemoryStream(pdfReceipt), "OrderReceipt.pdf", MediaTypeNames.Application.Pdf);
            mailMessage.Attachments.Add(attachment);

            await _smtpClient.SendMailAsync(mailMessage);
        }
    }
}
