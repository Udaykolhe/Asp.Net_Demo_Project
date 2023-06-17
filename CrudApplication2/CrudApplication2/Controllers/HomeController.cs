using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrudApplication2.Models;

namespace CrudApplication2.Controllers
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
                return View();
            }
            return View("Index");
        }
    }
}