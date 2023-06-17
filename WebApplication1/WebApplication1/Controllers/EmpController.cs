using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        public ActionResult about(string name =null)
        {
            return View();
        }
    }
}