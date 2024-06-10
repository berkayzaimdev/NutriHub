using MediatR;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Features.Categories.Commands;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Categories.Handlers
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand>
    {
        private readonly IRepository<Category> _repository;

        public CreateCategoryCommandHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Category 
            {
                Name = request.Name,
                Description = request.Description,
                ImageUrl = request.ImageUrl
            });
        }
    }
}
