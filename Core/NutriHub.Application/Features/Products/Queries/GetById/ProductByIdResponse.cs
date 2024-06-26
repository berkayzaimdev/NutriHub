using NutriHub.Application.Features.Products.Queries.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Products.Queries.GetById
{
    public class ProductByIdResponse : ProductResponse
    {
        public int Id { get; set; }
    }
}
