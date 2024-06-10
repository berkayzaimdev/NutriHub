using MediatR;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Features.Subcategories.Commands;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Subcategories.Handlers
{
    public class RemoveSubcategoryCommandHandler : IRequestHandler<RemoveSubcategoryCommand>
    {
        private readonly IRepository<Subcategory> _repository;

        public RemoveSubcategoryCommandHandler(IRepository<Subcategory> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveSubcategoryCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(request.Id);
        }
    }
}
