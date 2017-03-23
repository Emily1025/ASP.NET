﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace uav.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Documentation()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Acknowledgement()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}