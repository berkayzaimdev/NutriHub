using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Products.Commands
{
    public class CreateProductCommand : IRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public int SubcategoryId { get; set; }
    }
}
