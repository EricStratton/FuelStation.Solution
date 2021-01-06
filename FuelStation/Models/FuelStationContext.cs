using Microsoft.EntityFrameworkCore;

namespace FuelStation.Models
{
  public class FuelStationContext : DbContext
  {
    public DbSet<FuelType> FuelTypes { get; set; }
    public virtual DbSet<SpaceShip> SpaceShips { get; set; }
    public DbSet<Planet> Planets { get; set; }

    public DbSet<PlanetSpaceShipFuelType> PlanetSpaceShipFuelType { get; set; }

    public FuelStationContext(DbContextOptions options) : base(options) { }
  }
}