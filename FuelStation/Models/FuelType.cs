using System.Collections.Generic;

namespace FuelStation.Models 
{
  public class FuelType
  {
    public FuelType()
    {
      this.JoinEntries = new HashSet<PlanetSpaceShipFuelType>();  
    }

    public int FuelTypeId { get; set; }
    public string Name { get; set; }

    public virtual ICollection<PlanetSpaceShipFuelType> JoinEntries { get; set; }
  }
}