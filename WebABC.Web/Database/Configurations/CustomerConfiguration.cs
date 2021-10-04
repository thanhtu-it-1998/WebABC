using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebABC.Web.Database.Entities;

namespace WebABC.Web.Database.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {

            builder.ToTable("Customers");
            builder.HasKey(item => item.Id);
            builder.Property(item => item.Id).UseIdentityColumn();
            builder.Property(item => item.Name).HasMaxLength(255);
            builder.Property(item => item.Gender).HasMaxLength(10);
            builder.Property(item => item.Email).HasMaxLength(100);
            builder.Property(item => item.PhoneNumber).HasMaxLength(20);
            builder.Property(item => item.Note).HasMaxLength(500);
            builder.Property(item => item.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("getdate()");
            builder.Property(item => item.UpdatedAt).HasColumnType("datetime").HasDefaultValueSql("getdate()");
        }
    }
}
