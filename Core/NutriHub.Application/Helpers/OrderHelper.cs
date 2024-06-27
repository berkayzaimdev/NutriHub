using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Helpers
{
    public static class OrderHelper
    {
        public static string GenerateRandomOrderCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var randomString = new string(Enumerable.Repeat(chars, 6)
              .Select(s => s[random.Next(s.Length)]).ToArray());

            return $"S-{randomString}";
        }

        public static DateTime GetDeliveredDate()
        {
            DateTime now = DateTime.Now;

            return now.AddDays(DateTime.Now.DayOfWeek switch
            {
                DayOfWeek.Thursday => 4,
                DayOfWeek.Friday => 3,
                _ => 2,
            });
        }
    }
}
