using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Persistence.EFCore.Configurations
{
    public class ProductConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = 1,
                    Name = "Çilekli Protein Tozu",
                    Description = "Whey Protein kana hızlı karışan proteindir",
                    LargeImageUrl = "/productImages/largeImages/2454dbce12390ac24cc24a7d0a5886346b0b3b6e8d04ad9ee504233c62d67810_large.png",
                    CardImageUrl = "/productImages/cardImages/2454dbce12390ac24cc24a7d0a5886346b0b3b6e8d04ad9ee504233c62d67810_card.png",
                    Price = 1,
                    Stock = 999,
                    BrandId = 1,
                    CategoryId = 1,
                    SubcategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Name = "Kazein Protein",
                    Description = "Kazein protein gece sindirilen proteindir",
                    LargeImageUrl = "/productImages/largeImages/2454dbce12390ac24cc24a7d0a5886346b0b3b6e8d04ad9ee504233c62d67810_large.png",
                    CardImageUrl = "/productImages/cardImages/2454dbce12390ac24cc24a7d0a5886346b0b3b6e8d04ad9ee504233c62d67810_card.png",
                    Price = 9999,
                    Stock = 999,
                    BrandId = 2,
                    CategoryId = 1,
                    SubcategoryId = 3
                },
                new Product
                {
                    Id = 3,
                    Name = "Kreatin",
                    Description = "Kreatin antrenmanda yüksek güç artışı sağlar",
                    LargeImageUrl = "/productImages/largeImages/2454dbce12390ac24cc24a7d0a5886346b0b3b6e8d04ad9ee504233c62d67810_large.png",
                    CardImageUrl = "/productImages/cardImages/2454dbce12390ac24cc24a7d0a5886346b0b3b6e8d04ad9ee504233c62d67810_card.png",
                    Price = 55,
                    Stock = 999,
                    BrandId = 3,
                    CategoryId = 2,
                    SubcategoryId = 2
                }
            );

            builder.HasOne(p => p.Subcategory)
           .WithMany(s => s.Products)
           .HasForeignKey(p => p.SubcategoryId)
           .OnDelete(DeleteBehavior.NoAction); // Cascade davranışını kaldırıyoruz.
        }
    }
}
