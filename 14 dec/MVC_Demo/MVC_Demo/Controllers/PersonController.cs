using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MVC_Demo.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet]   //GET:Person
        public IActionResult PersonalDetails()
        {
            List<string> Options = new List<string>();
            Options.Add("Choose an option");
            Options.Add("Yes");
            Options.Add("No");
            ViewData["Options"] = new SelectList(Options);
            return View();
        }
    }
}
