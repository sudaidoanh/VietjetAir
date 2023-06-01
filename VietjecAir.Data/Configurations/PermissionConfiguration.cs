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
    public class PermissionConfiguration : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.ToTable("Permissions");
            builder.HasKey(x => new { x.GroupId, x.DocumentTypeId });
            builder.HasOne(x => x.Group).WithMany(c => c.permissions).HasForeignKey(x => x.GroupId);
            builder.HasOne(x => x.DocumentType).WithMany(c => c.permissions).HasForeignKey(c => c.DocumentTypeId);
            builder.Property(x => x.Permissions).IsRequired().HasMaxLength(128);
        }
    }
}
