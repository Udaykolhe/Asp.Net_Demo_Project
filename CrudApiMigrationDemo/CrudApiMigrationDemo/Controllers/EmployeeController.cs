using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrudApiMigrationDemo.Data;

namespace CrudApiMigrationDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var emp =  db.employee
                    .Join(db.addrees,
                    e => e.AddressId,
                    a => a.Id,
                    (e, a) => new
                    {   FirstName = e.FirstName,
                        LastName = e.LastName,
                        Email = e.Email,
                        Details = a.Details,
                        County = a.County,
                        State = a.State}
                    ).ToList();
                foreach (var em in emp)
                {
                    Console.WriteLine("{0} , {1} , {2} , {3} , {4} , {5}", em.FirstName, em.LastName, em.Email, em.Details,
                        em.County, em.State);
                }
            }

            return View();
           
        }
    }
}