using System.Collections.Generic;

namespace FuelStation.Models
{
  public class SpaceShip
  {
    public SpaceShip()
    {
      // this.Planets = new HashSet<PlanetSpaceShipFuelType>();
      this.FuelTypes = new HashSet<PlanetSpaceShipFuelType>();
    }

    public int SpaceShipId { get; set; }
    public string Name { get; set; }
    
    // public virtual ICollection<PlanetSpaceShipFuelType> Planets { get; set; }
    public virtual ICollection<PlanetSpaceShipFuelType> FuelTypes { get; set; }
  }

}