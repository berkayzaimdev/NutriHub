using Microsoft.Extensions.DependencyInjection;
using NutriHub.Application.Interfaces;
using NutriHub.Persistence.Context;
using NutriHub.Persistence.Repositories;
using NutriHub.Application.Services;
using NutriHub.Application.Interfaces.ProductInterfaces;
using NutriHub.Persistence.Repositories.ProductRepositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<NutriHubContext>();

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(IProductRepository), typeof(ProductRepository));

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
