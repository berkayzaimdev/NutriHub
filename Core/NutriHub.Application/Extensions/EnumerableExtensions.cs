using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Extensions
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> ApplyPagination<T>(this IEnumerable<T> values, int pageNumber = 1, int pageSize = 10)
        {
            return values.Skip((pageNumber - 1) * pageSize).Take(pageSize);
        }
    }
}
