using System.Collections.Generic;

namespace FuelStation.Models
{
  public class SpaceShip
  {
    public SpaceShip()
    {
      this.JoinEntries = new HashSet<PlanetSpaceShipFuelType>();
    }

    public int SpaceShipId { get; set; }
    public string Name { get; set; }
    
    public virtual ICollection<PlanetSpaceShipFuelType> JoinEntries { get; set; }
  }
}