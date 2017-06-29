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

    public IActionResult СongratulateUserAccount(string alias = "")
    {

      СongratulateUser res = new СongratulateUser();

      if (!String.IsNullOrEmpty(alias))
      {
        res = db.СongratulateUsers.Where(u => u.Alias == alias).FirstOrDefault();
      }
      return View(res);
    }

    [HttpPost]
    public JsonResult CreateCongratulateUser(string alias, string name, string surname, string birthdayDate)
    {
      var res = false;

      if (!String.IsNullOrEmpty(alias))
      {
        db.СongratulateUsers.Add(new СongratulateUser
        {
          Alias = alias,
          Name = name,
          Surname = surname,
          BirthdayDate = DateTime.Parse(birthdayDate)
        });
        db.SaveChangesAsync();
        res = true;
      }

      return Json(new
      {
        result = res,
      });
    }

  }
}
