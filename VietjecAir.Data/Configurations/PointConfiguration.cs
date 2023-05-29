using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VietjecAir.Data.Entities;

namespace VietjecAir.Data.Configurations
{
    public class PointConfiguration : IEntityTypeConfiguration<Point>
    {
        public void Configure(EntityTypeBuilder<Point> builder)
        {
            builder.ToTable("Points");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasMaxLength(10);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Local).IsRequired().HasMaxLength(90);
            builder.HasIndex(x => x.Name).IsUnique();
        }
    }
}
