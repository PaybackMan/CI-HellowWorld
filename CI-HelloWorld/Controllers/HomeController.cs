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
            ViewBag.Message = " eeaa aaa122211sqqq222aa  22 49     9  94  2!!";
      
            return View();
        }
 
        public ActionResult Contact()
        {
            ViewBag.Message = "Y a1tttt11oage.";

            return View();
        }
    }
}
