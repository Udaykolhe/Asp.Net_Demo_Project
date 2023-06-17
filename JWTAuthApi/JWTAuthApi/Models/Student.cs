    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OAuthApi.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        // [Index("IX_EmailName",Order=4,IsUnique=true)]
        public string Email { get; set; }

        // [Index("IX_MobileNumber",Order=5,IsUnique=true)]
        public long Mobile { get; set; }
        public string City { get; set; }
    }
}