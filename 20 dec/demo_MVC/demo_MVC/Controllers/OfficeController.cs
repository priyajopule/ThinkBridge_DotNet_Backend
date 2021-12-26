using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demo_MVC.Controllers
{
    public class OfficeController : Controller
    {
        // GET: Office
        public ActionResult Index()
        {
            return View();
        }

        // GET: Office/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Office/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Office/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Office/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Office/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


       
        
        public ActionResult Location()     
        {
            return View();
        }

       
        
        
        // GET: Office/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Office/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
