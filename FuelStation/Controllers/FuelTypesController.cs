using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using FuelStation.Models;

namespace FuelStation.Controllers
{
  public class FuelTypesController : Controller
  {
    private readonly FuelStationContext _db;

    public FuelTypesController(FuelStationContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<FuelType> model = _db.FuelTypes.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(FuelType fuelType)
    {
      _db.FuelTypes.Add(fuelType);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}