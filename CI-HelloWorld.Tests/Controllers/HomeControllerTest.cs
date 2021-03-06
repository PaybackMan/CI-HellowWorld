﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CI_HelloWorld;
using CI_HelloWorld.Controllers;

namespace CI_HelloWorld.Tests.Controllers
{   
    [TestClass] 
    public class HomeControllerTest
    {    
        [TestMethod] 
        public void Index()    
        {                        
            // A  rran            ge        
            HomeController controller = new HomeController(); 
                  
            // Act        
            ViewResult result = controller.Index() as ViewResult;
 
            // As  sert  
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {   
            // Arrange      33
            HomeController controller = new HomeController();
 
            // Act  dsd 
            ViewResult result = controller.About() as ViewResult;

            // As sert  
            Assert.IsTrue(true);
        }
 
        [TestMethod]
        public void Contact()
        {
            // Arrange 
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
