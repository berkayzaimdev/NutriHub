using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Favourites.Commands
{
    public class RemoveFromFavouriteCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveFromFavouriteCommand(int ıd)
        {
            Id = ıd;
        }
    }
}
