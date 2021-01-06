namespace FuelStation.Models
{
  public class PlanetSpaceShipFuelType
  {
    public int PlanetSpaceShipFuelTypeId { get; set; }
    public int PlanetId { get; set; }
    public int? SpaceShipId { get; set; }
    public int? FuelTypeId { get; set; }
    public Planet Planet { get; set; }
    public SpaceShip SpaceShip { get; set; }
    public FuelType FuelType { get; set; }
  }
}