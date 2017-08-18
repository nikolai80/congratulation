using AutoMapper;
using congratulation.BLL;
using congratulation.BLL.Services;
using congratulation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace congratulation.Controllers
{
  public class CongratulationController : Controller
  {
    ICongratulationCardService congratulationCardService;

     CongratulationController(ICongratulationCardService service)
    {
      congratulationCardService = service;
    }
    // GET: Congratulation
    public ActionResult Index()
    {
      return View();
    }
    public ActionResult EditCard(int id)
    {
      return View();
    }
    
    [HttpPost]
    public JsonResult AddCard(string headerText, string whom)
    {
      bool res = false;
      CongratulationCardVm congratulationCardVm = new CongratulationCardVm {
      HeaderText=headerText,
      Whom=whom};

      Mapper.Initialize(cfg => { cfg.CreateMap<CongratulationCardVm, CongratulationCardDto>(); });
      var congratulationCardDto = Mapper.Map<CongratulationCardVm, CongratulationCardDto>(congratulationCardVm);
      congratulationCardService.AddCard(congratulationCardDto);
      return Json(new {result=res });
    }

    protected override void Dispose(bool disposing)
    {
      congratulationCardService.Dispose();
      base.Dispose(disposing);
    }
  }
}