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
    public class RemoveFromFavouriteCommandHandler : IRequestHandler<RemoveFromFavouriteCommand>
    {
        private readonly IRepository<Favourite> _repository;

        public RemoveFromFavouriteCommandHandler(IRepository<Favourite> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveFromFavouriteCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(request.Id);
        }
    }
}
