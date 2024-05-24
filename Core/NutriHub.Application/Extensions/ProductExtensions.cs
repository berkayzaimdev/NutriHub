using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Extensions
{
    public static class ProductExtensions
    {
        public static IEnumerable<Product> OrderByQuery(this IEnumerable<Product> products, int orderBy)
        {
            switch (orderBy)
            {
                case 1:
                    return products;
                case 2:
                    return products.OrderBy(x => x.Price);
                case 3:
                    return products.OrderByDescending(x => x.Price);
                default:
                    return products;
            }
        }

        public static IEnumerable<Product> LimitByQuery(this IEnumerable<Product> products, int minPrice, int maxPrice)
        {
            if(minPrice == 0 && maxPrice == 0)
            {
                return products;
            }

            else if(minPrice == 0 && maxPrice != 0)
            {
                return products.Where(x => x.Price <= maxPrice);
            }

            else if (minPrice != 0 && maxPrice != 0)
            {
                return products.Where(x => x.Price >= minPrice && x.Price <= maxPrice);
            }

            else
            {
                return products;
            }
        }
    }
}
