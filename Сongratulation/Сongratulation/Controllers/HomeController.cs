using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Сongratulation.Models;

namespace Сongratulation.Controllers
{
  public class HomeController : Controller
  {

    CongratulationContext db;
    public HomeController(CongratulationContext context)
    {
      db = context;
    }


    public IActionResult Index()
    {
      return View(db.СongratulateUsers.ToList());
    }

  }
}
