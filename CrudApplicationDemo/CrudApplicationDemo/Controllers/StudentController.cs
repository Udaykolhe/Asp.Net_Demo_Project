using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrudApplicationDemo.Models;

namespace CrudApplicationDemo.Controllers
{
    [RoutePrefix("students")]
    public class StudentController : Controller
    {

        [Route("")]
        public ActionResult getAllStudents()
        {
            var student = students();
            ViewBag.studentList = student.Count();
            
            return View(student);
        }

        [Route("{id:int:min(5)}")]
        public ActionResult getStudent(int id)
        {
            var student = students().FirstOrDefault(x => x.m_id == id);
            return View(student);
        }
     
        //var student = students().where(x=>x.m_id = id).select(x=>x.c_address);

      
        private List<Student> students()
        {
            return new List<Student>()
            
{
                new Student()
                {
                    m_id = 1,
                    m_name = "Uday",
                    m_mobile_no = 9589139739
                 },
                 new Student()
                {
                    m_id = 2,
                    m_name = "Roshan",
                    m_mobile_no = 9589139731
                 },
                 new Student()
                {
                    m_id = 3,
                    m_name = "Shreyash",
                    m_mobile_no = 9589139732
                 },
                 new Student()
                {
                    m_id = 4,
                    m_name = "Aditya",
                    m_mobile_no = 9589139735
                 },
                 new Student()
                {
                    m_id = 5,
                    m_name = "Akash",
                    m_mobile_no = 9589139730
                 },
                 new Student()
                 { m_id=6, 
                     m_name="Steve", 
                     m_mobile_no = 1234567890 
                 },
                    new Student()
                    { 
                        m_id=7, 
                        m_name="Bill", 
                        m_mobile_no = 0987654321 
                    },
                    new Student()
                    { 
                        m_id=8, 
                        m_name="Ram", 
                        m_mobile_no = 1234509876 
                    },
                    new Student()
                    { 
                        m_id=9, 
                        m_name="Ron", 
                        m_mobile_no = 1245780954 
                    },
                    new Student()
                    { 
                        m_id=10, 
                        m_name="Rob", 
                        m_mobile_no = 1230983214 
                    }
             };
        }
    }
}