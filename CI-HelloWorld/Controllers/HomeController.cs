﻿﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CI_HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = " l !!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Yaa ur co ct pooage.";

            return View();
        }
    }
}
