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
  }
}