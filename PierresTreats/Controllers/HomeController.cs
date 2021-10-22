using Microsoft.AspNetCore.Mvc;

namespace PierresTreats.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }
  }
}