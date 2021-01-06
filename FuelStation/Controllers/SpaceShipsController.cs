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
  }
}