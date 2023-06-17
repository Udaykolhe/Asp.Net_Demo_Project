using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CrudApplicationDemo.Models
{
    public class Student
    {
        [Required]
        public int m_id { get; set; }
         [Required]
        public string m_name { get; set; }
         [Required]
       public long m_mobile_no { get; set; }
    }
}