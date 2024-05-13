using MediatR;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Features.Favourites.Commands;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Favourites.Handlers
{
    public class AddToFavouriteCommandHandler : IRequestHandler<AddToFavouriteCommand>
    {
        private readonly IRepository<Favourite> _repository;

        public AddToFavouriteCommandHandler(IRepository<Favourite> repository)
        {
            _repository = repository;
        }

        public async Task Handle(AddToFavouriteCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Favourite
            {
                ProductId = request.ProductId,
                UserId = request.UserId
            });
        }
    }
}
