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
    public class DocumentDetailConfiguration : IEntityTypeConfiguration<DocumentDetail>
    {
        public void Configure(EntityTypeBuilder<DocumentDetail> builder)
        {
            builder.ToTable("DocumentDetails");
            builder.HasKey(e => new { e.Id, e.DocumentId });
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Version).IsRequired();
            builder.Property(x => x.FilePath).HasMaxLength(256);
            builder.HasOne(x => x.Document).WithMany(c => c.Details).HasForeignKey(x => x.DocumentId);
            
        }
    }
}
