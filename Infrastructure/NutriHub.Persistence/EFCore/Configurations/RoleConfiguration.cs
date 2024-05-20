using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace NutriHub.Persistence.EFCore.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "2", Name = "Bronze Üye", NormalizedName = "BRONZE" },
                new IdentityRole { Id = "3", Name = "Silver Üye", NormalizedName = "SILVER" },
                new IdentityRole { Id = "4", Name = "Gold Üye", NormalizedName = "GOLD" },
                new IdentityRole { Id = "5", Name = "Platin Üye", NormalizedName = "PLATIN" },
                new IdentityRole { Id = "6", Name = "Yıldız Üye", NormalizedName = "STAR" }
            );
        }
    }
}
