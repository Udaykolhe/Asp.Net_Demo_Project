using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Employee
    {
        public int m_id { get; set; }
        public string m_name { get; set; }
        public string m_address { get; set; }

        

        public Employee()
        {

        }

        public Employee(int id  , string name , string add)
        {
            this.m_id = id;
            this.m_name = name;
            this.m_address = add;
        }
    }
}