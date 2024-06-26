using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Helpers
{
    public static class ClaimsHelper
    {
        public static string GetUserId()
        {
            try
            {
                var principal = Thread.CurrentPrincipal as ClaimsPrincipal;

                if(principal is null)
                {
                    throw new Exception();
                }

                var userId = principal.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier)
                    .Select(c => c.Value).Single();

                return userId;
            }
            catch (Exception ex)
            {
                ex.ToString();
                return string.Empty;
            }
        }
    }
}
