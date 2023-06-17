using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AspWebApiDemo1.Controllers
{
    public class EmployeeController : ApiController
    {

        public string[] 
             employeeData = { "Uday" , "Pavan" , "Piyush" , "Chetan"};

        [HttpGet]
        public string[] GetEmployees()
        {
            return employeeData;
        }

        public string GetEmployeesById(int id)
        {
            return employeeData[id];
        }

    }
}
