using System.Collections.Generic;

namespace FuelStation.Models
{
  public class Planet
  {
    public Planet()
    {
      this.SpaceShips = new HashSet<PlanetSpaceShipFuelType>();
      // this.FuelTypes = new HashSet<PlanetSpaceShipFuelType>();
    }

    public int PlanetId { get; set; }
    public string Name { get; set; }

    public virtual ICollection<PlanetSpaceShipFuelType> SpaceShips { get; set; }
    // public virtual ICollection<PlanetSpaceShipFuelType> FuelTypes { get; set; }
  }
}