using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietjecAir.Data.EF
{
    public class VietjetAirDbContextFactory : IDesignTimeDbContextFactory<VietjetAirDbContext>
    {
        public VietjetAirDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("VietjetAirDatabase");

            var optionsBuilder = new DbContextOptionsBuilder<VietjetAirDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new VietjetAirDbContext(optionsBuilder.Options);

        }
    }
}
