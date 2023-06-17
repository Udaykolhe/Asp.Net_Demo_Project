using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CrudApplication2.Models
{
    class Student
    {
        [Required(ErrorMessage = "please Enter FirstName")]
        public string m_firstname { get; set; }

        [Required(ErrorMessage = "please Enter LastName")]
        public string m_lastname { get; set; }

        [Required(ErrorMessage = "please Enter Email Id")]
        [EmailAddress]
        public string m_email { get; set; }

        [Required(ErrorMessage = "please Enter Mobile Number")]
        public long m_mobile { get; set; }

    }
}