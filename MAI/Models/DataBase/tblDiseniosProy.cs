//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MAI.Models.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblDiseniosProy
    {
        public tblDiseniosProy()
        {
            this.tblMetodoProy = new HashSet<tblMetodoProy>();
        }
    
        public int tblDiseniosProy_ID { get; set; }
        public string disProy_nombre { get; set; }
    
        public virtual ICollection<tblMetodoProy> tblMetodoProy { get; set; }
    }
}
