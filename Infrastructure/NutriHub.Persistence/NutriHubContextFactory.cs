using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using NutriHub.Persistence.Context;

namespace NutriHub.Persistence
{
    public class NutriHubContextFactory : IDesignTimeDbContextFactory<NutriHubContext>
    {
        public NutriHubContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<NutriHubContext>();
            builder.UseSqlServer("Server=DESKTOP-M1UE4EP;" +
                "initial Catalog=NutriHub;" +
                "integrated Security=true;" +
                "TrustServerCertificate=true;");

            return new NutriHubContext(builder.Options);
        }
    }
}
