using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Abstractions.Interfaces.CategoryInterfaces;
using NutriHub.Persistence.Repositories.CategoryRepositories;
using NutriHub.Domain.Entities;
using NutriHub.Persistence.Context;
using NutriHub.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NutriHub.Application.Abstractions.Interfaces.ProductInterfaces;
using NutriHub.Application.Abstractions.Interfaces.SubcategoryInterfaces;
using NutriHub.Persistence.Repositories.SubcategoryRepositories;
using NutriHub.Persistence.Repositories.ProductRepositories;
using NutriHub.Application.Abstractions.Services;
using NutriHub.Persistence.Services;

namespace NutriHub.Persistence.Helpers
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ISubcategoryRepository, SubcategoryRepository>();

            services.AddScoped<IUserService, UserService>();
        }
    }
}
