using System.Collections.Generic;

namespace FuelStation.Models 
{
  public class FuelType
  {
    public FuelType()
    {
      this.SpaceShips = new HashSet<PlanetSpaceShipFuelType>(); 
      // this.Planets = new HashSet<PlanetSpaceShipFuelType>(); 
    }

    public int FuelTypeId { get; set; }
    public string Name { get; set; }

    public ICollection<PlanetSpaceShipFuelType> SpaceShips { get; set; }
    // public ICollection<PlanetSpaceShipFuelType> Planets { get; set; }
  }
}