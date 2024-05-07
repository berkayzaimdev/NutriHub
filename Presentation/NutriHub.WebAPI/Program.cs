using MediatR;
using NutriHub.Application.Features;
using NutriHub.WebAPI.Extensions;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.ConfigureSqlContext(builder.Configuration);

builder.Services.ConfigureIdentity();

builder.Services.AddHttpClient();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetAssembly(typeof(MediatorAssembly))));

builder.Services.ConfigureJWT(builder.Configuration);

builder.Services.AddPersistenceServices();

builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication(); // �nce oturum a�ma
app.UseAuthorization();  // sonra yetkilendirme

app.MapControllers();

app.Run();
