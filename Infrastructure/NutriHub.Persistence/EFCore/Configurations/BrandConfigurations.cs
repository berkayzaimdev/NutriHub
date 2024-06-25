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
    public class BrandConfigurations : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasData(
                new Brand
                {
                    Id = 1,
                    Name = "Protein Ocean",
                    Description = "Protein Ocean, deniz kaynaklı proteinlerle formüle edilen yenilikçi takviyeler sunan bir markadır. Sağlıklı yaşam ve sporcular için özel olarak tasarlanmış ürünleriyle bilinir.",
                    ImageUrl = "..."
                },
                new Brand
                {
                    Id = 2,
                    Name = "NutriHub",
                    Description = "NutriHub, doğal ve organik içeriklere sahip besin takviyeleri sunan bir markadır. Sağlıklı yaşamı desteklemek ve beslenme ihtiyaçlarını karşılamak için çeşitli ürünler sunar.",
                    ImageUrl = "..."
                },
                new Brand
                {
                    Id = 3,
                    Name = "Hardline",
                    Description = "Hardline, sporcuların en zorlu antrenmanlarda dahi performanslarını artırmak için tasarlanmış yüksek kaliteli takviyeler sunan bir markadır. Güvenilir ve etkili ürünleriyle tanınır.",
                    ImageUrl = "..."
                }
            );
        }

    }
}
