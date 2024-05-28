using MediatR;
using NutriHub.Application.Features;
using NutriHub.WebAPI.Extensions;
using NutriHub.WebAPI.Middlewares;
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

builder.Services.ConfigureSwagger();

builder.Services.ConfigureSMTP(builder.Configuration);

builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddProblemDetails();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        policy =>
        {
            policy.WithOrigins("http://localhost:3000","http://localhost:4000")
                  .AllowAnyHeader()
                  .AllowAnyMethod()
                  .DisallowCredentials();
        });

});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowSpecificOrigin");

app.UseAuthentication(); // �nce oturum a�ma
app.UseAuthorization();  // sonra yetkilendirme
app.UseStaticFiles();
app.MapControllers();

app.Run();
