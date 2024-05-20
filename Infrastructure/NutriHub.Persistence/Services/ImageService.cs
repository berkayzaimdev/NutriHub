using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using NutriHub.Application.Abstractions.Services;
using NutriHub.Application.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Persistence.Services
{
    public class ImageService : IImageService
    {
        private readonly IWebHostEnvironment _environment;

        public ImageService(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public async Task AddImagesAsync(string fileExtension, string cardFileName, string largeFileName, IFormFile image)
        {
            var imageFormat = GetImageFormat(fileExtension);

            var cardImagePath = EnsureDirectoryExists(Path.Combine(_environment.WebRootPath, "productImages/cardImages"));
            var largeImagePath = EnsureDirectoryExists(Path.Combine(_environment.WebRootPath, "productImages/largeImages"));

            var cardFilePath = Path.Combine(cardImagePath, cardFileName);
            var largeFilePath = Path.Combine(largeImagePath, largeFileName);

            await using (var imageStream = image.OpenReadStream())
            {
                ImageHelper.ResizeImage(imageStream, largeFilePath, 400, 400, imageFormat);
            }

            await using (var imageStream = image.OpenReadStream())
            {
                ImageHelper.ResizeImage(imageStream, cardFilePath, 200, 200, imageFormat);
            }
        }

        public string GetLargeImageUrl(string fileName) => $"/productImages/largeImages/{fileName}";
        public string GetCardImageUrl(string fileName) => $"/productImages/cardImages/{fileName}";

        private static ImageFormat GetImageFormat(string fileExtension)
        {
            return fileExtension switch
            {
                ".jpg" or ".jpeg" => ImageFormat.Jpeg,
                ".png" => ImageFormat.Png,
                ".gif" => ImageFormat.Gif,
                _ => throw new NotSupportedException($"Unsupported image format: {fileExtension}")
            };
        }

        private static string EnsureDirectoryExists(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return path;
        }
    }
}
