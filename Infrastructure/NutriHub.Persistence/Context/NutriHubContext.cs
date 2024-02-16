using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Persistence.Context
{
    public class NutriHubContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-EC025DF;" +
                "initial Catalog=NutriHub;" +
                "integrated Security=true;" +
                "TrustServerCertificate=true;");
        }


    }
}
