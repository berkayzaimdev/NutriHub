using Microsoft.Extensions.DependencyInjection;
using NutriHub.Persistence.Context;
using NutriHub.Persistence.Repositories;
using NutriHub.Application.Services;
using NutriHub.Persistence.Repositories.ProductRepositories;
using NutriHub.Persistence.Repositories.CategoryRepositories;
using NutriHub.Persistence.Repositories.SubcategoryRepositories;
using NutriHub.Business.Services;
using NutriHub.Business.Managers;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Abstractions.Interfaces.CategoryInterfaces;
using NutriHub.Application.Abstractions.Interfaces.ProductInterfaces;
using NutriHub.Application.Abstractions.Interfaces.SubcategoryInterfaces;
using NutriHub.Persistence.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using NutriHub.Domain.Entities;
using NutriHub.WebAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.ConfigureSqlContext(builder.Configuration);
builder.Services.ConfigureIdentity();

builder.Services.AddHttpClient();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ServiceRegistiration).Assembly));
builder.Services.AddPersistenceServices();

builder.Services.AddApplicationService(builder.Configuration);
builder.Services.AddAutoMapper(typeof(Program));

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
