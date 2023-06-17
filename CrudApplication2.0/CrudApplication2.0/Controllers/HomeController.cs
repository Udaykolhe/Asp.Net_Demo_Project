using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrudApplication2._0.Models;

namespace CrudApplication2._0.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult submitData(Student std)
        {
            if (ModelState.IsValid)
            {
                ModelState.Clear();
                return View(std);
            }
            return View("Index");
        }
    }
}