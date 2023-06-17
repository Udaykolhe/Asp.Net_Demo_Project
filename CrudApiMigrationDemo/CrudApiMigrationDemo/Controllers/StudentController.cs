using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CrudApiMigrationDemo.Data;
using CrudApiMigrationDemo.Models;

namespace CrudApiMigrationDemo.Controllers
{
    public class StudentController : ApiController
    {
       // [HttpGet]
       //// [Authorize(Roles=("SuperAdmin"))]
       // //[Route("api/Student/GetAllStudent")]
       // public HttpResponseMessage GetAllStudent()
       // {
       //     using (ApplicationDbContext dbContext = new ApplicationDbContext())
       //     {
       //         return Request.CreateResponse(HttpStatusCode.OK, dbContext.Test4.ToList());
       //     }
       // }

       // [HttpGet]
       //// [Authorize(Roles=("User"))]
       // public HttpResponseMessage GetStudentById(int id)
       // {
       //     using (ApplicationDbContext dbContext = new ApplicationDbContext())
       //     {
       //         var std = dbContext.Test4.FirstOrDefault(s => s.ID == id);
       //         if (std != null)
       //         {
       //             return Request.CreateResponse(HttpStatusCode.OK, std);
       //         }
       //         else
       //         {
       //             return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Student with id" + id + "nnot found");
       //         }
       //     }
       // }

       // [HttpPost]
       // public HttpResponseMessage AddNewUser(Test test)
       // {
       //     using (ApplicationDbContext dbContext = new ApplicationDbContext())
       //     {
       //         if (test != null)
       //         {
       //             dbContext.Test4.Add(test);
       //             dbContext.SaveChanges();
       //             return Request.CreateResponse(HttpStatusCode.OK, test);
       //         }
       //         else
       //         {
       //             return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Provide  Correct Data");
       //         }
       //     }
       // }

       // //[Authorize(Roles = ("Admin"))]
       // ////[Route("api/Student/GetAllStudent")]
       // //public HttpResponseMessage Put(int id, Student student)
       // //{
       // //    using (ApplicationDbContext dbContext = new ApplicationDbContext())
       // //    {
       // //        var std = dbContext.Students.FirstOrDefault(s => s.Id == id);
       // //        if (std !=null)
       // //        {
       // //            std.FirstName = student.FirstName;
       // //            std.LastName = student.LastName;
       // //            std.Age = student.Age;
       // //            std.Email = student.Email;
       // //            std.Mobile = student.Mobile;
       // //            std.City = student.City;
                    
       // //            dbContext.SaveChanges();
       // //            return Request.CreateResponse(HttpStatusCode.OK, std);

       // //        }
       // //        else
       // //        {
       // //            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee With Id" + id + "Not Found In Update Field");
       // //        }
       // //    }
       // //}

       // //[Authorize(Roles=("Admin,SuperAdmin"))]
       // //public HttpResponseMessage Delete(int id)
       // //{
       // //    using (ApplicationDbContext dbContext = new ApplicationDbContext())
       // //    {
       // //        var std = dbContext.Students.FirstOrDefault(s => s.Id == id);

       // //        if (std != null)
       // //        {
       // //            dbContext.Students.Remove(std);
       // //            dbContext.SaveChanges();
       // //            return Request.CreateResponse(HttpStatusCode.OK, std);
       // //        }
       // //        else
       // //        {
       // //            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee With Id" + id + "Not Found In database for    delete Field");
       // //        }
       // //    }
       // //}

       // //public HttpResponseMessage Patch(int id, [FromBody]string firstName)
       // //{
       // //    using (ApplicationDbContext dbContext = new ApplicationDbContext())
       // //    {
       // //        var std = dbContext.Students.FirstOrDefault(s => s.Id == id);
       // //        if (std != null)
       // //        {
       // //            std.FirstName = firstName;
                    
       // //            dbContext.SaveChanges();
       // //            return Request.CreateResponse(HttpStatusCode.OK, std);

       // //        }
       // //        else
       // //        {
       // //            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee With Id" + id + "Not Found In Update Field");
       // //        }
       // //    }
       // //}

       
    }
}
