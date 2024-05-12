using Microsoft.AspNetCore.Identity;
using NutriHub.Application.Abstractions.Services;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Azure.Core;

namespace NutriHub.Persistence.Services
{
    public class EmailSender : IEmailSender<User>
    {
        private readonly SmtpClient _smtpClient;

        public EmailSender()
        {
            _smtpClient = new SmtpClient("smtp.outlook.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("nutrihub@outlook.com.tr", "nutrihb-123"),
                EnableSsl = true,
            };
        }

        public async Task SendConfirmationLinkAsync(User user, string email, string confirmationLink)
        {
            var mailMessage = GetMailMessage(confirmationLink);
            mailMessage.To.Add(email);
            await _smtpClient.SendMailAsync(mailMessage);
        }

        public Task SendPasswordResetCodeAsync(User user, string email, string resetCode)
        {
            throw new NotImplementedException();
        }

        public Task SendPasswordResetLinkAsync(User user, string email, string resetLink)
        {
            throw new NotImplementedException();
        }

        private MailMessage GetMailMessage(string confirmationLink)
        {
            var mailBody = $"Merhaba,<br /><br />Hesabınızı doğrulamak için lütfen <a href='{confirmationLink}'>bu linke</a> tıklayın.";

            return new MailMessage
            {
                From = new MailAddress("nutrihub@outlook.com.tr"),
                Subject = "NutriHub Hesap Doğrulama",
                Body = mailBody,
                IsBodyHtml = true,
            };
        }
    }
}
