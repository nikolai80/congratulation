﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace congratulation.Controllers
{
    public class CongratulationController : Controller
    {
        // GET: Congratulation
        public ActionResult Index()
        {
            return View();
        }
    public ActionResult EditCard(int id) {
      return View();
    }
    public ActionResult AddCard()
    {
      return View();
    }
  }
}