using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.ViewModels.ProductViewModels
{
    public class ProductCardViewModel
    {
        public Product Product { get; set; }
        public bool IsFavourited { get; set; }
    }
}
