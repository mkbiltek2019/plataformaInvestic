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
    
    public partial class course_rel_user
    {
        public string course_code { get; set; }
        public long user_id { get; set; }
        public sbyte status { get; set; }
        public string role { get; set; }
        public int group_id { get; set; }
        public long tutor_id { get; set; }
        public Nullable<int> sort { get; set; }
        public Nullable<int> user_course_cat { get; set; }
        public int relation_type { get; set; }
        public Nullable<int> legal_agreement { get; set; }
    }
}
