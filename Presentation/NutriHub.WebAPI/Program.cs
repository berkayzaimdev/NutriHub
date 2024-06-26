using MediatR;
using NutriHub.Application.Features;
using NutriHub.Persistence.Logging;
using NutriHub.Persistence.Services;
using NutriHub.WebAPI.Extensions;
using NutriHub.WebAPI.Middlewares;
using StackExchange.Redis;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.ConfigureSqlContext(builder.Configuration);

builder.Services.ConfigureIdentity();

builder.Services.AddHttpClient();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assembly: Assembly.GetAssembly(typeof(MediatorAssembly))));

builder.Services.ConfigureJWT(builder.Configuration);

builder.Services.AddPersistenceServices();

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.ConfigureSwagger();

builder.Services.ConfigureSMTP(builder.Configuration);

builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddProblemDetails();

builder.Services.AddLogging(config =>
{
    config.ClearProviders();
    config.AddConsole();
});

builder.Services.AddSingleton<ILoggerProvider, DatabaseLoggerProvider>();

builder.Services.AddSingleton<IConnectionMultiplexer>(sp =>
{
    var configuration = ConfigurationOptions.Parse(builder.Configuration["Redis:ConnectionString"], true);
    return ConnectionMultiplexer.Connect(configuration);
});

builder.Services.AddScoped<RedisCacheService>();

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

app.UseAuthentication(); // önce oturum açma
app.UseAuthorization();  // sonra yetkilendirme
app.UseStaticFiles();
app.MapControllers();

app.Run();
