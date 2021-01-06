using System.Collections.Generic;

namespace FuelStation.Models
{
  public class Planet
  {
    public Planet()
    {
      this.JoinEntries = new HashSet<PlanetSpaceShipFuelType>();
    }

    public int PlanetId { get; set; }
    public string Name { get; set; }

    public ICollection<PlanetSpaceShipFuelType> JoinEntries { get; }
  }
}