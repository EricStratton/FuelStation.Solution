using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace FuelStation.Models
{
  public class FuelStationContextFactory : IDesignTimeDbContextFactory<FuelStationContext>
  {
    FuelStationContext IDesignTimeDbContextFactory<FuelStationContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

          var builder = new DbContextOptionsBuilder<FuelStationContext>();
          var connectionString = configuration.GetConnectionString("DefaultConnection");

          builder.UseMySql(connectionString);

          return new FuelStationContext(builder.Options);
    }
  }
}