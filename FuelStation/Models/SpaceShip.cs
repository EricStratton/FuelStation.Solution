using System.Collections.Generic;

namespace FuelStation.Models
{
  public class SpaceShip
  {
    public SpaceShip()
    {
      this.FuelTypes = new HashSet<PlanetSpaceShipFuelType>();
    }

    public int SpaceShipId { get; set; }
    public string Name { get; set; }
    
    public virtual ICollection<PlanetSpaceShipFuelType> FuelTypes { get; set; }
  }

}