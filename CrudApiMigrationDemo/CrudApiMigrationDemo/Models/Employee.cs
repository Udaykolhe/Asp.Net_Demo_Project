﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrudApiMigrationDemo.Data
{
    public class Employee
    {
        public int Id { get; set; }
         public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Address AddressId { get; set; }
        public string Code { get; set; }

    }
}
