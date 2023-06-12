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
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.ToTable("Flights");
            builder.HasKey(x => x.FlightNo);
            builder.Property(x => x.PointofLoading).IsRequired();
            builder.Property(x => x.PointofUnloading).IsRequired();
            builder.Property(x => x.TimeLoading).IsRequired(false);
            builder.Property(x => x.TimeUnloading).IsRequired(false);
        }
    }
}
