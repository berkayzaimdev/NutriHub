using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Favourites.Commands
{
    public class AddToFavouriteCommand : IRequest
    {
        public int ProductId { get; set; }
        public string UserId { get; set; }

        public AddToFavouriteCommand(int productId, string userId)
        {
            ProductId = productId;
            UserId = userId;
        }
    }
}
