using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebABC.Web.Database.Entities;

namespace WebABC.Web.Database.Configurations
{
    public class SlideConfiguration : IEntityTypeConfiguration<Slide>
    {
        public void Configure(EntityTypeBuilder<Slide> builder)
        {
            builder.ToTable("Slides");
            builder.HasKey(item => item.Id);
            builder.Property(item => item.Id).UseIdentityColumn();
            builder.Property(item => item.Link).HasMaxLength(100);
            builder.Property(item => item.Image).HasMaxLength(100);
            builder.Property(item => item.Context).HasColumnType("text");
        }
    }
}
