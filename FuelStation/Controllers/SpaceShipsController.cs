using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using FuelStation.Models;

namespace FuelStation.Controllers
{
  public class SpaceShipsController : Controller
  {
    private readonly FuelStationContext _db;

    public SpaceShipsController(FuelStationContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<SpaceShip> model = _db.SpaceShips.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.PlanetId = new SelectList(_db.Planets, "PlanetId", "Name");
      ViewBag.FuelTypeId = new SelectList(_db.FuelTypes, "FuelTypeId", "Name");
      return View();
    }

    [HttpPost] // Create SpaceShip and chose FuelType and Home Planet
    public ActionResult Create(SpaceShip spaceShip, int PlanetId, int FuelTypeId)
    {
      _db.SpaceShips.Add(spaceShip);
      if(PlanetId != 0 && FuelTypeId != 0)
      {
        _db.PlanetSpaceShipFuelType.Add(new PlanetSpaceShipFuelType() { PlanetId = PlanetId, FuelTypeId = FuelTypeId, SpaceShipId = spaceShip.SpaceShipId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisSpaceShip = _db.SpaceShips
          .Include(spaceShip => spaceShip.JoinEntries)
          .ThenInclude(join => join.FuelType)
          .Include(spaceShip => spaceShip.JoinEntries)
          .ThenInclude(join => join.Planet)
          .FirstOrDefault(spaceShip => spaceShip.SpaceShipId == id);
      return View(thisSpaceShip);
    }

    public ActionResult Edit(int id)
    {
      var thisSpaceShip = _db.SpaceShips.FirstOrDefault(spaceShip => spaceShip.SpaceShipId == id);
      ViewBag.PlanetId = new SelectList(_db.Planets, "PlanetId", "Name");
      ViewBag.FuelTypeId = new SelectList(_db.FuelTypes, "FuelTypeId", "Name");
      return View(thisSpaceShip);
    }

    [HttpPost]
    public ActionResult Edit(SpaceShip spaceShip, int PlanetId, int FuelTypeId, int Id)
    {
      if(PlanetId != 0 && FuelTypeId != 0)
      {
        _db.PlanetSpaceShipFuelType.Add(new PlanetSpaceShipFuelType() { PlanetId = PlanetId, FuelTypeId = FuelTypeId, SpaceShipId = spaceShip.SpaceShipId  });
      }
      _db.Entry(spaceShip).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}