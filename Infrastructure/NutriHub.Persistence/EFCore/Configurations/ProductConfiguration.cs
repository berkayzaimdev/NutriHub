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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = 1,
                    Name = "1000 gr",
                    Description = "Whey Protein kana hızlı karışan proteindir",
                    LargeImageUrl = "...",
                    CardImageUrl = "...",
                    Price = 178,
                    BrandId = 1,
                    CategoryId = 1,
                    SubcategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Name = "3000 gr",
                    Description = "Kazein protein gece sindirilen proteindir",
                    LargeImageUrl = "...",
                    CardImageUrl = "...",
                    Price = 300,
                    BrandId = 2,
                    CategoryId = 1,
                    SubcategoryId = 3
                },
                new Product
                {
                    Id = 3,
                    Name = "500 gr",
                    Description = "Kreatin antrenmanda yüksek güç artışı sağlar",
                    LargeImageUrl = "...",
                    CardImageUrl = "...",
                    Price = 55,
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
