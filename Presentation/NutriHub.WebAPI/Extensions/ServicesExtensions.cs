using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NutriHub.Application.Abstractions.Interfaces.CategoryInterfaces;
using NutriHub.Application.Abstractions.Interfaces.ProductInterfaces;
using NutriHub.Application.Abstractions.Interfaces.SubcategoryInterfaces;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Abstractions.Services;
using NutriHub.Domain.Entities;
using NutriHub.Persistence.EFCore.Context;
using NutriHub.Persistence.Repositories;
using NutriHub.Persistence.Services;
using NutriHub.Application.Abstractions.Interfaces.CommentInterfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace NutriHub.WebAPI.Extensions
{
    public static class ServicesExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) => services.AddDbContext<NutriHubContext>(options => options.UseSqlServer(configuration.GetConnectionString("sqlConnection")));

        public static void ConfigureIdentity(this IServiceCollection services)
        {
            var builder = services.AddIdentity<User, IdentityRole>(opts =>
            {
                opts.Password.RequireDigit = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequiredLength = 6;
                opts.User.RequireUniqueEmail = false;
            })
                .AddEntityFrameworkStores<NutriHubContext>()
                .AddDefaultTokenProviders();
        }

        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ISubcategoryRepository, SubcategoryRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ITokenService, TokenService>();
        }

        public static void ConfigureJWT(this IServiceCollection services, IConfiguration configuration)
        {
            var jwtSettings = configuration.GetSection("JwtSettings"); // appsettings.json 'a eriştik
            var secretKey = jwtSettings["secretKey"]; // JwtSettings alanındaki parametreye eriştik

            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(options =>
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = jwtSettings["validIssuer"],
                ValidAudience = jwtSettings["validAudience"],
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
            });
        }
    }
}
