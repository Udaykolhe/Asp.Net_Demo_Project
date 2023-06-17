using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrudApiMigrationDemo.Data
{
    public class Address
    {
        public int Id { get; set; }
        public string Details { get; set; }
        public string State { get; set; }
        public string County { get; set; }
     }
}
