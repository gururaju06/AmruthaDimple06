using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;


//User interactive logic
namespace WebApplication1.Controllers
{
    public class TestController : Controller // Test is my contriller and TestController is my class
    {
        public string MyFirstMethod() // Action Method
        {
            return ("Hello");
        }

        public ActionResult GetMyFirstHTMlPage()
        {

            CustomerBAL a = new CustomerBAL();

            Customer b = a.GetCustomer();

            ViewBag.CustomerData = b;

            return View("GetMyFirstHTMlPage");
        }
    }
}