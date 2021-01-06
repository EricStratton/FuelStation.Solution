using System.Collections.Generic;

namespace FuelStation.Models 
{
  public class FuelType
  {
    public FuelType()
    {
      this.SpaceShips = new HashSet<PlanetSpaceShipFuelType>(); 
      this.Planets = new HashSet<PlanetSpaceShipFuelType>(); 
    }
    public int FuelId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<PlanetSpaceShipFuelType> Planets { get; set; }
    public virtual ICollection<PlanetSpaceShipFuelType> SpaceShips { get; set; }
  }
}