using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Carts.Commands
{
    public class AddCartItemCommand : IRequest
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string UserId { get; set; }

        public AddCartItemCommand(int productId, int quantity, string userId)
        {
            ProductId = productId;
            Quantity = quantity;
            UserId = userId;
        }
    }
}
