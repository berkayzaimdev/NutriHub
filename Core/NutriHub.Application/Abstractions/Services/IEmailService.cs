using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Abstractions.Services
{
    public interface IEmailService
    {
        Task SendConfirmationMailAsync(string to, string verificationLink);
        Task SendRankUpEmailAsync(string to, string newRank);
        Task SendOrderReceiptEmailAsync(string to, byte[] pdfReceipt);
    }
}
