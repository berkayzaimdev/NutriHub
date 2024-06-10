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
    public class CreateSubcategoryCommandHandler : IRequestHandler<CreateSubcategoryCommand>
    {
        private readonly IRepository<Subcategory> _repository;

        public CreateSubcategoryCommandHandler(IRepository<Subcategory> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateSubcategoryCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Subcategory 
            {
                Name = request.Name,
                Description = request.Description,
                ImageUrl = request.ImageUrl,
                CategoryId = request.CategoryId
            });
        }
    }
}
