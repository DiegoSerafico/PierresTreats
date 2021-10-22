using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using PierresTreats.Models;
using System.Threading.Tasks;
using System.Linq;
using System.Security.Claims;

namespace PierresTreats.Controllers
{
  public class AccountController : Controller
  {
    private readonly PierresTreatsContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public AccountController (UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, PierresTreatsContext db)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _db = db;
    }

    public ActionResult Index()
    {
        return View();
    }
  }
}