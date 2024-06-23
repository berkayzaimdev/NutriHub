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
    public class UpdateSubcategoryCommandHandler : IRequestHandler<UpdateSubcategoryCommand>
    {
        private readonly IRepository<Subcategory> _repository;

        public UpdateSubcategoryCommandHandler(IRepository<Subcategory> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateSubcategoryCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetAsync(request.Id);

            if(value is null)
            {
                throw new Exception();
            }

            value.Name = request.Name;
            value.Description = request.Description;
            value.ImageUrl = request.ImageUrl;

            await _repository.UpdateAsync(value);
        }
    }
}
