using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NutriHub.Domain.Entities;
using NutriHub.Persistence.Context;

namespace NutriHub.WebAPI.Extensions
{
    public static class ServicesExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) => services.AddDbContext<NutriHubContext>(options => options.UseSqlServer(configuration.GetConnectionString("sqlConnection")));

        public static void ConfigureIdentity(this IServiceCollection services)
        {
            var builder = services.AddIdentity<AppUser, IdentityRole>(opts =>
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

        //public static void AddPersistenceServices(this IServiceCollection services)
        //{

        //}
    }
}
