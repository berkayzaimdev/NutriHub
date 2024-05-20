using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Abstractions.Services
{
    public interface IImageService
    {
        Task AddImagesAsync(string fileExtension, string cardFileName, string largeFileName, IFormFile image);
        string GetLargeImageUrl(string fileName);
        string GetCardImageUrl(string fileName);
    }
}
