using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using NutriHub.Persistence.EFCore.Context;

namespace NutriHub.WebAPI.ContextFactory
{
    public class NutriHubContextFactory : IDesignTimeDbContextFactory<NutriHubContext>
    {
        public NutriHubContext CreateDbContext(string[] args)
        {
            // configuration
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // DbContextOptionsBuilder
            var builder = new DbContextOptionsBuilder<NutriHubContext>()
                .UseSqlServer(configuration.GetConnectionString("sqlConnection"),
                prj => prj.MigrationsAssembly("NutriHub.WebAPI"));

            return new NutriHubContext(builder.Options);
        }
    }
}
