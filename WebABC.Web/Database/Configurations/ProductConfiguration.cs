using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebABC.Web.Database.Entities;

namespace WebABC.Web.Database.Configurations
{
    public class ProductConfiguration: IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(item => item.Id);
            builder.Property(item => item.Id).UseIdentityColumn();
            builder.Property(item => item.Name).HasMaxLength(100);
            builder.Property(item => item.Description).HasColumnType("text");
            builder.Property(item => item.UnitPrice).HasColumnType("decimal(18, 2)");
            builder.Property(item => item.PromotionPrice).HasColumnType("decimal(18, 2)");
            builder.Property(item => item.Image).HasMaxLength(255);
            builder.Property(item => item.Unit).HasMaxLength(255);
            builder.Property(item => item.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("getdate()");
            builder.Property(item => item.UpdatedAt).HasColumnType("datetime").HasDefaultValueSql("getdate()");

            builder.HasOne(item => item.TypeProduct).WithMany(item => item.Products).HasForeignKey(item => item.IdType);


        }
    }
}
