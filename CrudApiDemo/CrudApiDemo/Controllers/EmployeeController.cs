using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using  System.Net.Http;
using CrudApiDemo.Models;

namespace CrudApiDemo.Controllers.Employee
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        HttpClient client = new HttpClient();
        List<tbl_emp_data> list = new List<tbl_emp_data>();

        public ActionResult GetAllEmp()
        {
            
            client.BaseAddress = new Uri("http://localhost:10484/api/EmployeeApi");
            var response = client.GetAsync("EmployeeApi");
            response.Wait();
            var test= response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<List<tbl_emp_data>>();
                display.Wait();
                list = display.Result;
            }

            return View(list);
        }



        public ActionResult Create(tbl_emp_data emp)
        {
            client.BaseAddress = new Uri("http://localhost:10484/api/EmployeeApi");
            var response = client.PostAsJsonAsync<tbl_emp_data>("EmployeeApi",emp);
            response.Wait();

            var test =response.Result;
            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("GetAllEmp","Employee");
               
            }

                   return View("Create");
        }

        public ActionResult Details(int id)
        {

            tbl_emp_data e = null;
            client.BaseAddress = new Uri("http://localhost:10484/api/EmployeeApi");
            var response = client.GetAsync("EmployeeApi?id" + id.ToString());
            response.Wait();
            var test= response.Result;


            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<tbl_emp_data>();
                display.Wait();
                e = display.Result;
            }

            return View(e);
        }

        public ActionResult Delete(int id)
        {
            tbl_emp_data emp = null;
            client.BaseAddress = new Uri("http://localhost:10484/api/EmployeeApi");
            var res = client.GetAsync("EmployeeApi?id=" + id.ToString());
            res.Wait();
            var test =res.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<tbl_emp_data>();
                display.Wait();
                emp =display.Result; 
            }
            return View(emp);
        }

        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
      {
          client.BaseAddress = new Uri("http://localhost:10484/api/EmployeeApi");
          var res = client.DeleteAsync("EmployeeApi/" + id.ToString());
          res.Wait();
          var test = res.Result;
          if (test.IsSuccessStatusCode)
          {
              return RedirectToAction("GetAllEmp");
          }

          return View("Delete");
      }
    }
}