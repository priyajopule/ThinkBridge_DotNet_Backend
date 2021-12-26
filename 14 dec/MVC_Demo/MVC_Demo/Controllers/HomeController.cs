using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using MVC_Demo.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        /*
        public IActionResult test()
        {
            ViewData["name"] = "my mvc demo";
            ViewBag.Address = "Maharashtra";
            List<string> names = new List<string>();
            names.Add("priya");
            names.Add("priyanka");
            names.Add("aditya");
            ViewBag.NameList = names;



            List<Product> products = new List<Product>
            {

                new Product{Id=01, Name="mobile", price=40000 },
                new Product{Id=02, Name="mobile1", price=15000 },
                new Product{Id=03, Name="mobile2", price=25000 },
                new Product{Id=04, Name="mobile3", price=35000 },
                new Product{Id=05, Name="mobile4", price=10000 },

            };




            ViewBag.ProductList = products;
            return View();
        }*/


        [HttpGet]   //GET:Person
        public IActionResult PersonDetails()
        {
            List<string> Options = new List<string>();
            Options.Add("Choose an option");
            Options.Add("Yes");
            Options.Add("No");
            ViewData["Options"] = new SelectList(Options);
            return View();
        }


        [HttpPost]
        public IActionResult PersonDetails(FormCollection fc, ICollection<string>hobbies)
        {
            ViewBag.firstname = fc["firstname"];
            ViewBag.lastname = fc["lastname"];
            ViewBag.phone = fc["phone"];
            ViewBag.gender = fc["gender"];
            ViewBag.hobbies = hobbies;
            ViewBag.options = fc["options"];
            return View("Details");
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
