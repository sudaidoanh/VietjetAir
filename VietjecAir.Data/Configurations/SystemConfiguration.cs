using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VietjecAir.Data.Entities;

namespace VietjecAir.Data.Configurations
{
    public class SystemConfiguration : IEntityTypeConfiguration<Entities.System>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.System> builder)
        {
            builder.ToTable("ConfigureSystems");
            builder.HasKey(e => e.Id);
        }
    }
}
