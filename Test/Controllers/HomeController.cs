﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
                // komentarz
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
                // visual
            return View();
        }

        public ActionResult Contact()
        { //sdfgsdsdfadsf
            ViewBag.Message = "Your contact page.";
                // studio
            return View();
        }
    }
}
