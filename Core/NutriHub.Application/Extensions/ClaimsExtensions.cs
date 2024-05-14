using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Extensions
{
    public static class ClaimsExtensions
    {
        public static string GetUserId(this ClaimsPrincipal user)
        {
            if (user == null)
            {
                return string.Empty;
            }

            var claim = user.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);
            return claim?.Value ?? string.Empty;
        }
    }
}
