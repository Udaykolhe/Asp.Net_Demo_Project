using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiWithSql.Models;


namespace WebApiWithSql.Controllers
{
     public class EmployeeApiController : ApiController
    {
        EMSystemEntities ems = new EMSystemEntities();

         [System.Web.Http.HttpGet]
        public IHttpActionResult Action()
      {
          List<employeeDetail> obj = ems.employeeDetails.ToList();

            return Ok(obj);
      }

         

         [System.Web.Http.HttpGet]
         public IHttpActionResult Index(int id)
         {
             var obj = ems.employeeDetails.Where(m => m.Id == id).FirstOrDefault();
             return Ok(obj);
         }

    }
}
