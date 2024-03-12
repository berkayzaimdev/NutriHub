using Microsoft.Extensions.DependencyInjection;
using NutriHub.Application.Interfaces;
using NutriHub.Persistence.Context;
using NutriHub.Persistence.Repositories;
using NutriHub.Application.Services;
using NutriHub.Application.Interfaces.ProductInterfaces;
using NutriHub.Persistence.Repositories.ProductRepositories;
using NutriHub.Application.Interfaces.CategoryInterfaces;
using NutriHub.Persistence.Repositories.CategoryRepositories;
using NutriHub.Application.Interfaces.SubcategoryInterfaces;
using NutriHub.Persistence.Repositories.SubcategoryRepositories;
using NutriHub.Business.Services;
using NutriHub.Business.Managers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient();

builder.Services.AddScoped<NutriHubContext>();

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(IProductRepository), typeof(ProductRepository));
builder.Services.AddScoped(typeof(ICategoryRepository), typeof(CategoryRepository));
builder.Services.AddScoped(typeof(ISubcategoryRepository), typeof(SubcategoryRepository));

builder.Services.AddScoped(typeof(IGenericService<,,>), typeof(GenericService<,,>));
builder.Services.AddScoped(typeof(IBrandService), typeof(BrandManager));

builder.Services.AddApplicationService(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
