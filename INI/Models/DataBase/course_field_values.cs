//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace INI.Models.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class course_field_values
    {
        public int id { get; set; }
        public string course_code { get; set; }
        public int field_id { get; set; }
        public string field_value { get; set; }
        public System.DateTime tms { get; set; }
    }
}