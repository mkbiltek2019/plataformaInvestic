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
    
    public partial class tblNivel
    {
        public tblNivel()
        {
            this.tblNivelIdioma = new HashSet<tblNivelIdioma>();
            this.tblNivelLengua = new HashSet<tblNivelLengua>();
        }
    
        public long tblNivel_ID { get; set; }
        public string tblNivel_nivel { get; set; }
    
        public virtual ICollection<tblNivelIdioma> tblNivelIdioma { get; set; }
        public virtual ICollection<tblNivelLengua> tblNivelLengua { get; set; }
    }
}
