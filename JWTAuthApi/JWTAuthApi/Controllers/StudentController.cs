using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OAuthApi.Data;
using OAuthApi.Models;

namespace OAuthApi.Controllers
{
    public class StudentController : ApiController
    {
    
        [HttpGet]
        [Authorize(Roles="SuperAdmin")]
        public HttpResponseMessage GetAllStudent()
        {
            using (AppDbContext dbContext = new AppDbContext())
            {
                return Request.CreateResponse(HttpStatusCode.OK, dbContext.Students.ToList());
     
            }
        }

        [HttpGet]
        [Authorize(Roles="User")]
        public HttpResponseMessage GetStudentById(int id)
        {
            using (AppDbContext dbContext = new AppDbContext())
            {
                var std = dbContext.Students.FirstOrDefault(s => s.Id == id);
                if (std != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, std);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Student with id" + id + "nnot found");
                }
            }
        }

        [HttpPost]
        [Authorize(Roles="Admin")]
        public HttpResponseMessage AddNewStudent(Student std)
        {
            using (AppDbContext dbContext = new AppDbContext())
            {
                if (std != null)
                {
                    dbContext.Students.Add(std);
                    dbContext.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, std);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Provide  Correct Data");
                }
            }
        }

        [Authorize(Roles = ("Admin,SuperAdmin"))]
        [HttpPut]
        public HttpResponseMessage Put(int id, Student student)
        {
            using (AppDbContext dbContext = new AppDbContext())
            {
                var std = dbContext.Students.FirstOrDefault(s => s.Id == id);
                if (std != null)
                {
                    std.FirstName = student.FirstName;
                    std.LastName = student.LastName;
                    std.Age = student.Age;
                    std.Email = student.Email;
                    std.Mobile = student.Mobile;
                    std.City = student.City;

                    dbContext.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, std);

                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee With Id" + id + "Not Found In Update Field");
                }
            }
        }

        [Authorize(Roles = ("SuperAdmin"))]
        public HttpResponseMessage Delete(int id)
        {
            using (AppDbContext dbContext = new AppDbContext())
            {
                var std = dbContext.Students.FirstOrDefault(s => s.Id == id);

                if (std != null)
                {
                    dbContext.Students.Remove(std);
                    dbContext.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, std);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee With Id" + id + "Not Found In database for    delete Field");
                }
            }
        }

    }
}
