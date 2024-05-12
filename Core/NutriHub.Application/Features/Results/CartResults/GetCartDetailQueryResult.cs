using NutriHub.Application.DTOs.CartItemDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Results.CartResults
{
    public class GetCartDetailQueryResult
    {
        public decimal TotalPrice { get; set; }
        public int TotalQuantity { get; set; }
        public IEnumerable<CartItemDto> CartItems { get; set; }
    }
}
