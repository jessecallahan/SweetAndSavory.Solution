using Microsoft.AspNetCore.Mvc;
using SweetAndSavory.Models;
using System.Linq;

namespace SweetAndSavory.Controllers
{
  public class HomeController : Controller
  {

    private readonly SweetAndSavoryContext _db;

    public HomeController(SweetAndSavoryContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult Splash()
    {
      ViewBag.Treats = _db.Treats.ToList();
      ViewBag.Flavors = _db.Flavors.ToList();
      return View();
    }

  }
}

