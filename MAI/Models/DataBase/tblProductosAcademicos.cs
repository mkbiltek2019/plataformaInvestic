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
    
    public partial class tblProductosAcademicos
    {
        public long tblProductosAcademicos_ID { get; set; }
        public string proaca_tituloProducto { get; set; }
        public Nullable<System.DateTime> proaca_anoTerminacion { get; set; }
        public long tblCategoriaProductos_ID { get; set; }
        public long tblHojaVida_ID { get; set; }
    
        public virtual tblHojaVida tblHojaVida { get; set; }
        public virtual tblCategoriaProductos tblCategoriaProductos { get; set; }
    }
}