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
    
    public partial class tblLenguas
    {
        public tblLenguas()
        {
            this.tblNivelLengua = new HashSet<tblNivelLengua>();
        }
    
        public long tblLenguas_ID { get; set; }
        public string len_nombre { get; set; }
        public string len_descripcion { get; set; }
    
        public virtual ICollection<tblNivelLengua> tblNivelLengua { get; set; }
    }
}
