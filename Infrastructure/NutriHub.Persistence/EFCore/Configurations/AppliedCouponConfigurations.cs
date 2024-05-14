using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Persistence.EFCore.Configurations
{
    public class AppliedCouponConfigurations : IEntityTypeConfiguration<AppliedCoupon>
    {
        public void Configure(EntityTypeBuilder<AppliedCoupon> builder)
        {
            builder.HasKey(x => x.UserId);

            builder
                .HasOne(ac => ac.User)
                .WithMany() 
                .HasForeignKey(ac => ac.UserId);

            builder
                .HasOne(ac => ac.Coupon)
                .WithMany()
                .HasForeignKey(ac => ac.CouponId);
        }
    }
}
