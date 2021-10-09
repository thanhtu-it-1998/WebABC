using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebABC.Web.Database.Entities;

namespace WebABC.Web.Database.Configurations
{
    public class BillDetailConfiguration : IEntityTypeConfiguration<BillDetail>
    {
        public void Configure(EntityTypeBuilder<BillDetail> builder)
        {
            builder.ToTable("BillDetails");
            builder.HasKey(item => item.Id);
            builder.Property(item => item.Id).UseIdentityColumn();
            builder.Property(item => item.IdBill).IsRequired();
            builder.Property(item => item.IdProduct).IsRequired();
            builder.Property(item => item.UnitPrice).HasColumnType("decimal(18, 2)");
            builder.Property(item => item.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("getdate()");
            builder.Property(item => item.UpdatedAt).HasColumnType("datetime").HasDefaultValueSql("getdate()");

            builder.HasOne(item => item.Product).WithMany(item => item.BillDetails).HasForeignKey(item => item.IdProduct);
            builder.HasOne(item => item.Bill).WithMany(item => item.BillDetails).HasForeignKey(item => item.IdBill);


        }
    }
}
