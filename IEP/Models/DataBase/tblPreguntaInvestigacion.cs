//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IEP.Models.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblPreguntaInvestigacion
    {
        public int id { get; set; }
        public int Consecutivo { get; set; }
        public string Pregunta { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public bool PreguntaPrincipal { get; set; }
        public int idGrupoInvestigacion { get; set; }
    
        public virtual tblGrupoInvestigacion tblGrupoInvestigacion { get; set; }
    }
}
