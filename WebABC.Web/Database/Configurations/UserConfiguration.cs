using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebABC.Web.Database.Entities;

namespace WebABC.Web.Database.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(item => item.Id);
            builder.Property(item => item.Id).UseIdentityColumn();
            builder.Property(item => item.FullName).HasMaxLength(255);
            builder.Property(item => item.Password).HasMaxLength(255);
            builder.Property(item => item.Email).HasMaxLength(100);
            builder.Property(item => item.RememberToken).HasMaxLength(100);
            builder.Property(item => item.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("getdate()");
            builder.Property(item => item.UpdatedAt).HasColumnType("datetime").HasDefaultValueSql("getdate()");
        }
    }
}
