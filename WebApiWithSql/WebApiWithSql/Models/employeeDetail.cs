//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiWithSql.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class employeeDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Working_Type { get; set; }
        public string Day { get; set; }
        public Nullable<System.DateTime> In_Time { get; set; }
        public Nullable<System.DateTime> Out_Time { get; set; }
    }
}