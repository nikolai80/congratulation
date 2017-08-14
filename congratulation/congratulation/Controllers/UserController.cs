using AutoMapper;
using congratulation.BLL;
using congratulation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace congratulation.Controllers
{
  public class UserController : Controller
  {
    IUserService userService;
    public UserController(IUserService serv)
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

    public ActionResult UserPage(int? id)
    {
      UserViewModel res;
      if (id == null || id <= 0)
      {
        res = new UserViewModel();
      }
      else
      {
        var userDto = userService.GetUser(id);

        Mapper.Initialize(cfg => cfg.CreateMap<UserDto, UserViewModel>());
        res = Mapper.Map<UserDto, UserViewModel>(userDto);
      }

      return View(res);
    }

    protected override void Dispose(bool disposing)
    {
      userService.Dispose();
      base.Dispose(disposing);
    }
  }
}