using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CrudApplication2._0.Models
{
    public class Student
    {
        [DisplayName("First Name : :")]
        [NameValidation]
        [Required(ErrorMessage = "Please Enter FirstName")]
        public string m_firstname { get; set; }

        [DisplayName("Last Name : ")]
        [Required(ErrorMessage = "Please Enter LastName")]
        public string m_lastname { get; set; }

        [DisplayName("Email Id : ")]
        [Required(ErrorMessage = "Please Enter Email Id")]
        [EmailAddress]
        public string m_email { get; set; }

        [DisplayName("Mobile No : ")]
        [Required(ErrorMessage = "Please Enter Mobile Number")]
        public long m_mobile { get; set; }

       
    }
}