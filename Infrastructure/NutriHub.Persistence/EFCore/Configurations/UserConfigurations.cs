using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Persistence.EFCore.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            var hasher = new PasswordHasher<User>();

            var adminUser = new User
            {
                Id = "1",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                FirstName = "Admin",
                LastName = "Admin",
                Email = "admin@nutrihub.com",
                NormalizedEmail = "ADMIN@NUTRIHUB.COM",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            adminUser.PasswordHash = hasher.HashPassword(adminUser, "admin123");

            var regularUser = new User
            {
                Id = "2",
                UserName = "regularuser",
                NormalizedUserName = "REGULARUSER",
                FirstName = "Regular",
                LastName = "User",
                Email = "user@nutrihub.com",
                NormalizedEmail = "REGULARUSER@NUTRIHUB.COM",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            regularUser.PasswordHash = hasher.HashPassword(regularUser, "user123");

            builder.HasData(adminUser, regularUser);
        }
    }
}
