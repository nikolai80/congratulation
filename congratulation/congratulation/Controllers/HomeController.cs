using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using congratulation.BLL;
using congratulation.BLL.DTO;
using AutoMapper;
using congratulation.ViewModels;

namespace congratulation.Controllers
{
  public class HomeController : Controller
  {
    IUserService userService;
    public HomeController(IUserService serv)
    {
      
      userService = serv;
    }
    public ActionResult Index()
    {
      IEnumerable<UserDto> userDtos = userService.GetAllUsers();
      Mapper.Initialize(cfg => cfg.CreateMap<UserDto, UserViewModel>());
      var users = Mapper.Map<IEnumerable<UserDto>, List<UserViewModel>>(userDtos);
      return View(users);
    }

    public ActionResult About()
    {
      ViewBag.Message = "Your application description page.";

      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Your contact page.";

      return View();
    }
    protected override void Dispose(bool disposing)
    {
      userService.Dispose();
      base.Dispose(disposing);
    }
  }
}