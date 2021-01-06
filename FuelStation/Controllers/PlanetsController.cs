using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using FuelStation.Models;

namespace FuelStation.Controllers
{
  public class PlanetsController : Controller
  {
    private readonly FuelStationContext _db;

    public PlanetsController(FuelStationContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Planet> model = _db.Planets.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Planet planet)
    {
      _db.Planets.Add(planet);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}