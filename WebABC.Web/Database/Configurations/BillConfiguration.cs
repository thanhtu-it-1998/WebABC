using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebABC.Web.Database.Entities;

namespace WebABC.Web.Database.Configurations
{
    public class BillConfiguration : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> builder)
        {

            builder.ToTable("Bills");
            builder.HasKey(item => item.Id);
            builder.Property(item => item.Id).UseIdentityColumn();
            builder.Property(item => item.IdCustomer).IsRequired();
            builder.Property(item => item.DateOrder).HasColumnType("datetime").HasDefaultValueSql("getdate()");
            builder.Property(item => item.Payment).HasMaxLength(255);
            builder.Property(item => item.Note).HasMaxLength(500);
            builder.Property(item => item.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("getdate()");
            builder.Property(item => item.UpdatedAt).HasColumnType("datetime").HasDefaultValueSql("getdate()");

            builder.HasOne(item => item.Customer).WithMany(item => item.Bills).HasForeignKey(item => item.IdCustomer);
        }
    }
}
