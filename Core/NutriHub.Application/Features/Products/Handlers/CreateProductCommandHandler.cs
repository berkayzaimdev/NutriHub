using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Abstractions.Services;
using NutriHub.Application.Features.Products.Commands;
using NutriHub.Application.Helpers;
using NutriHub.Domain.Entities;
using System.Drawing.Imaging;

namespace NutriHub.Application.Features.Products.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly IRepository<Product> _repository;
        private readonly IImageService _imageService;

        public CreateProductCommandHandler(IRepository<Product> repository, IImageService imageService)
        {
            _repository = repository;
            _imageService = imageService;
        }

        public async Task Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            var hash = HashHelper.ComputeSha256Hash(command.Image.FileName);
            var fileExtension = Path.GetExtension(command.Image.FileName).ToLower();

            var cardFileName = $"{hash}_card{fileExtension}";
            var largeFileName = $"{hash}_large{fileExtension}";

            await _imageService.AddImagesAsync(fileExtension, cardFileName, largeFileName, command.Image);

            var product = new Product
            {
                Name = command.Name,
                Description = command.Description,
                Price = command.Price,
                Stock = command.Stock,
                LargeImageUrl = $"/productImages/largeImages/{largeFileName}",
                CardImageUrl = $"/productImages/cardImages/{cardFileName}",
                BrandId = command.BrandId,
                CategoryId = command.CategoryId,
                SubcategoryId = command.SubcategoryId
            };

            await _repository.CreateAsync(product);
        }
    }
}
