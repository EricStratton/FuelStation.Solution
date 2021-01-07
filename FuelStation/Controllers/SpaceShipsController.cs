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
      return View();
    }

    [HttpPost]
    public ActionResult Create(SpaceShip spaceShip, int PlanetId)
    {
      _db.SpaceShips.Add(spaceShip);
      if(PlanetId != 0)
      {
        _db.PlanetSpaceShipFuelType.Add(new PlanetSpaceShipFuelType() { PlanetId = PlanetId, SpaceShipId = spaceShip.SpaceShipId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}