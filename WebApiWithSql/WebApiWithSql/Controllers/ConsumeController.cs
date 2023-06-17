using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using WebApiWithSql.Models;

namespace WebApiWithSql.Controllers
{
    public class ConsumeController : Controller
    {
        HttpClient client = new HttpClient();
        // GET: Consume
        public ActionResult Index()
        {

            List<employeeDetail> list = new List<employeeDetail>();
            client.BaseAddress = new Uri("http://localhost:3920/api/EmployeeApi");
            var response = client.GetAsync("EmployeeApi");
            response.Wait();


            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<List<employeeDetail>>();
                display.Wait();
                list = display.Result;
            }
                
            return View(list);
        }
    }
}