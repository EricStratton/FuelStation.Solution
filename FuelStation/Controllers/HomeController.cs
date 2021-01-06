using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}