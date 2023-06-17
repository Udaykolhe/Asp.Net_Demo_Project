using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrudApplicationDemo.Models;

namespace CrudApplicationDemo.Controllers
{

    public class HomeController : Controller
    {
       [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string postDataUsingPara(string firstname, string lastname)
        {
            return "From Parameter:---"  + firstname + ","+  lastname;
        }

        [HttpPost]
        public string postDataUsingReq()
        {
            string firstname = Request["firstname"];
            string lastname = Request["lastname"];

            return "From Request:---" + firstname + "," + lastname;
        }

        [HttpPost]
        public string postDatausingFormCollection(FormCollection form)
        {
            string firstname = form["firstname"];
            string lastname = form["lastname"];
            return "From Collecction:---" + firstname + "," + lastname;
        }

        [HttpPost]
        public ActionResult postUsingBinding(Student std)
        {
            List<Student> emp = new List<Student>();

            if (ModelState.IsValid)
            {
                emp.Add(std);
                
                return View("submitData",emp);
            }
            return View("Index");
            
        }

   
    }
}