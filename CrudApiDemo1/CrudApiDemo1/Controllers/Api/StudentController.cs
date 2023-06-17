using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CrudApiDemo1.Models;

namespace CrudApiDemo1.Controllers.Api
{
    public class StudentController : ApiController
    {
        List<Student> std = new List<Student>();
        EmpMngSystemEntities db = null;

        //Get : api/Student

        [HttpGet]
        public HttpResponseMessage Gets()
        {
           
            using (db = new EmpMngSystemEntities())
            {
                std = db.Student.ToList();
                if (std.Count != 0)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, std);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No records Found");
                }
          }
        }


        //Get : api/Student/id
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            using (db = new EmpMngSystemEntities())
            {
              var student=  db.Student.FirstOrDefault(model => model.Id == id);
              if (student !=null)
              {
                  return Request.CreateResponse(HttpStatusCode.OK, student);
              }
              else
              {
                  return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee Id = " +id+ " Not Found");
              }
            }
        }


        // Post : api/Student
        [HttpPost]
        public HttpResponseMessage Insert(Student std )
        {
            using (db = new EmpMngSystemEntities())
            {
                if (std  !=null)
                {
                    db.Student.Add(std);
                    db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.Created, "Data Saved");
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Please Provide right Information!!");
                }
               
            }
        }

        // Put :api/Student/id
        [HttpPut]
        public HttpResponseMessage Put(int id,Student std)
        {
            
            using (db  = new EmpMngSystemEntities())
            {
                var student = db.Student.FirstOrDefault(model => model.Id == id);

                if (student != null)
                {
                   // student.Id = std.Id;
                    student.FirstName = std.FirstName;
                    student.LastName = std.LastName;
                    student.Age = std.Age;
                    student.Email = std.Email;
                    student.Mobile = std.Mobile;
                    student.City = std.City;
                  

                    db.SaveChanges();

                    return Request.CreateResponse(HttpStatusCode.OK, "Updated Succesfully");
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee Id = " + id + " Not Found");
                }
   
            }
        }


        //Delete : api/Student/id
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
         using (db = new EmpMngSystemEntities())
            {
                var std = db.Student.FirstOrDefault(m => m.Id == id);
                if (std != null)
                {
                    db.Student.Remove(std);
                    db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, "Deleted Succesfully");
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee Id = " + id + " Not Found");
                }
            }
        }

    }
}
