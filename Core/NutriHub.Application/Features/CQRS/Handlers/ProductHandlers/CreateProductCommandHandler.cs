using MediatR;
using NutriHub.Application.Features.CQRS.Commands.ProductCommands;
using NutriHub.Application.Interfaces;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.CQRS.Handlers.ProductHandlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly IRepository<Product> _repository;

        public CreateProductCommandHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Product 
            {
                Name = request.Name,
                Description = request.Description,
                ImageUrl = request.ImageUrl,
                BrandId = request.BrandId,
                CategoryId = request.CategoryId,
                SubcategoryId = request.SubcategoryId
            });
        }
    }
}
