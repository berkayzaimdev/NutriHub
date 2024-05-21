using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Helpers
{
    public static class EmailHelper
    {
        public const string Sender = "nutrihub@outlook.com.tr";

        public static string GetBody(string content)
        {
            return MailBody.Replace("{{Content}}", content);
        }

        private const string MailBody = @"
<!DOCTYPE html>
<html lang='en'>
<head>
    <meta charset='UTF-8'>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
        }
        .container {
            max-width: 600px;
            margin: 0 auto;
            background-color: #333;
            padding: 20px;
            border: 1px solid #dddddd;
            border-radius: 10px;
            color: #ffffff;
        }
        .header {
            text-align: center;
            border-bottom: 1px solid #dddddd;
            padding-bottom: 10px;
            margin-bottom: 20px;
        }
        .header img {
            max-width: 200px;
        }
        .header h1 {
            margin: 0;
            font-size: 24px;
        }
        .content {
            margin-bottom: 20px;
        }
        .footer {
            background-color: #444;
            color: #ffffff;
            padding: 10px;
            border-radius: 0 0 10px 10px;
            margin-top: 20px;
        }
        .footer p {
            margin: 0;
        }
        .footer a {
            color: #ffffff;
            text-decoration: none;
        }
    </style>
</head>
<body>
    <div class='container'>
        <div class='header'>
            <img src='cid:logo' alt='Logo'>
            <h1>NutriHub</h1>
        </div>
        <div class='content'>
            {{Content}}
        </div>
        <div class='footer'>
            <h3>İletişim Bilgileri</h3>
            <p>Adres: NutriHub Vitamin ve Gıda Takviyeleri Paz. Tic. A.Ş. Maltepe, İstanbul</p>
            <p>Tel: 212 37 22</p>
            <p>E-Posta: <a href='mailto:nutrihub@outlook.com.tr'>nutrihub@outlook.com.tr</a></p>
            <p>Mersis No: 0296-0408-8660-0010</p>
        </div>
    </div>
</body>
</html>";
    }
}
