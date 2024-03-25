using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace NutriHub.Persistence.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Name = "Bronze Üye", NormalizedName = "BRONZE" },
                new IdentityRole { Name = "Silver Üye", NormalizedName = "SILVER" },
                new IdentityRole { Name = "Gold Üye", NormalizedName = "GOLD" },
                new IdentityRole { Name = "Platin Üye", NormalizedName = "PLATIN" },
                new IdentityRole { Name = "Yıldız Üye", NormalizedName = "STAR" }
            );
        }
    }
}
