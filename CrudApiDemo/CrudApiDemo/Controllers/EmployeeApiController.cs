using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CrudApiDemo.Models;

namespace CrudApiDemo.Controllers
{

    public class EmployeeApiController : ApiController
    {

        EmpMngSystemEntities1 db = new EmpMngSystemEntities1();

        [System.Web.Http.HttpGet]
        public IHttpActionResult GetAllEmp()
        {
            List<tbl_emp_data> list = db.tbl_emp_data.ToList();
            return Ok(list);
        }


        [System.Web.Http.HttpGet]
        public IHttpActionResult GetEmpById(int id)
        {
            var data = db.tbl_emp_data.Where(m => m.Id == id).FirstOrDefault();
            return Ok(data);
        }

        [System.Web.Http.HttpPost]
        public IHttpActionResult AddNewEmp(tbl_emp_data emp)
        {
            db.tbl_emp_data.Add(emp);
            db.SaveChanges();
            return Ok();
        }

        [System.Web.Http.HttpPut]
        public IHttpActionResult UpdateEmp(tbl_emp_data emp)
        {
            db.tbl_emp_data.Add(emp);
            db.SaveChanges();
            return Ok();
        }

        [System.Web.Http.HttpDelete]
        public IHttpActionResult DeleteEmp(int id)
        {
            var data = db.tbl_emp_data.Where(m => m.Id == id).FirstOrDefault();
            db.Entry(data).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            return Ok();
        }
    
    }
    
      
}
