using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Сongratulation.Models;
using Сongratulation.DAL;

namespace Сongratulation.Controllers
{
  public class HomeController : Controller
  {

    UnitOfWork unitOfWork;
    public HomeController(CongratulationContext context)
    {
      unitOfWork = new UnitOfWork(context);
    }

    public IActionResult Index()
    {
      return View(unitOfWork.СongratulateUsers.GetAll());
    }

    public IActionResult СongratulateUserAccount(string alias = "")
    {

      СongratulateUser res = new СongratulateUser();

      if (!String.IsNullOrEmpty(alias))
      {
        res = unitOfWork.СongratulateUsers.GetAll().Where(u => u.Alias == alias).FirstOrDefault();
      }
      return View(res);
    }

    [HttpPost]
    public JsonResult CreateCongratulateUser(string alias, string name, string surname, string birthdayDate)
    {
      var res = false;

      if (!String.IsNullOrEmpty(alias))
      {
        unitOfWork.СongratulateUsers.Create(new СongratulateUser
        {
          Alias = alias,
          Name = name,
          Surname = surname,
          BirthdayDate = DateTime.Parse(birthdayDate)
        });
        unitOfWork.Save();
        res = true;
      }

      return Json(new
      {
        result = res,
      });
    }

  }
}
