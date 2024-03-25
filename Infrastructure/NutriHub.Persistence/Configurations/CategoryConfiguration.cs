using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Persistence.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = 1, Name = "Protein Tozu", Description = "Sporcuların protein ihtiyacını karşılamak için kullanılan toz formundaki ürünler." },
                new Category { Id = 2, Name = "Kreatin", Description = "Kas kütlesini artırmaya ve performansı artırmaya yardımcı olan bir takviye maddesi." }
            );
        }
    }
}
