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
    public class SubcategoryConfiguration : IEntityTypeConfiguration<Subcategory>
    {
        public void Configure(EntityTypeBuilder<Subcategory> builder)
        {
            builder.HasData(
                new Subcategory
                {
                    Id = 1,
                    Name = "Whey Protein",
                    Description = "Sporcuların protein ihtiyacını hızlı ve etkili bir şekilde karşılayan whey protein tozları, kas gelişimini destekler ve antrenman sonrası iyileşmeyi hızlandırır.",
                    ImageUrl = "...",
                    CategoryId = 1
                },

                new Subcategory
                {
                    Id = 2,
                    Name = "Kreatin Monohidrat",
                    Description = "Kreatin monohidrat, enerji üretimini artırarak spor performansını destekler ve yoğun egzersizlerde kas gücünü artırabilir. Sporcular arasında popüler bir besin takviyesidir.",
                    ImageUrl = "...",
                    CategoryId = 2
                },

                new Subcategory
                {
                    Id = 3,
                    Name = "Kazein Protein",
                    Description = "Kazein protein, yavaş sindirilen bir protein türüdür ve uzun süreli protein salımı sağlar. Bu özelliği ile genellikle gece yatmadan önce tüketilir ve gece boyunca kasların beslenmesini sağlar.",
                    ImageUrl = "...",
                    CategoryId = 1
                },

                new Subcategory
                {
                    Id = 4,
                    Name = "Amino Asitler",
                    Description = "Amino asitler, vücudun temel yapı taşlarıdır ve kas onarımı ve büyümesi için gereklidir. Antrenman öncesi veya sonrası amino asit takviyesi almak, kas proteini sentezini artırabilir ve iyileşmeyi hızlandırabilir.",
                    ImageUrl = "...",
                    CategoryId = 1
                },

                new Subcategory
                {
                    Id = 5,
                    Name = "Kreatin HCL",
                    Description = "Kreatin HCL (hidroklorid), kreatin monohidratın bir türevidir ve daha yüksek çözünürlük ve emilim sağlayabilir. Kreatin HCL, yoğun egzersizlerde performansı artırmak ve kas gücünü desteklemek için tercih edilen bir besin takviyesidir.",
                    ImageUrl = "...",
                    CategoryId = 2
                }
            );
        }

    }
}
