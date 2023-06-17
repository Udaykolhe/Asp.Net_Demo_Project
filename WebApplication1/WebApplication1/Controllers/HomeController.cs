using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            var data = getEmployee();
            viewBag();
            viewData();
            return View(data);

        }

        [HttpPost]
        public ActionResult Index(Employee emp)
        {
            return View();
        }

        // GET: Home
        public ActionResult about(string name = null)
        {
            return View("~/Views/Emp/about.cshtml");
        }

        private Employee getEmployee()
        {
            return new Employee(1, "Naman", "Noida");

        }

        //GET : Home
        public ActionResult viewBag()
        {
            ViewBag.MyCustom = "Uday Kolhe";

            ViewBag.MyList = new List<string>(){"Uday"  , "Shreyash" , "Aditya"};

            List<Employee> empList = new List<Employee>()
            {
               new Employee() {m_id = 1 , m_name = "Uday" , m_address = "Burhanpur"} ,
               new Employee() {m_id = 2 , m_name = "Pavan" , m_address = "Nepanagar"} ,
               new Employee() {m_id = 3 , m_name = "Rahul" , m_address = "Burhanpur"} 
            };

            ViewBag.myEmpList = empList;
            return View();
        }

        public ActionResult viewData()
        {
            ViewData["myList"] = "pavann kumar";

            return View();
        }


    }
}