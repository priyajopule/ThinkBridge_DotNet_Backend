using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnitTestingDemo.Models;

namespace UnitTestingDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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




        public ActionResult DetailProduct(int id)

        {

            var product = new Product { Id = 101, Name = "Lenovo" };

            return View("Detials", product);

        }



        public ActionResult SomeAction(int id)

        {

            if (id < 5)

            {

                return RedirectToAction("Index");

            }

            else

            {

                return RedirectToAction("About");

            }

        }
    }
}