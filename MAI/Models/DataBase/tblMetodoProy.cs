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
    
    public partial class tblMetodoProy
    {
        public tblMetodoProy()
        {
            this.tblProyectosInvestigacion = new HashSet<tblProyectosInvestigacion>();
        }
    
        public long tblMetodoProy_ID { get; set; }
        public Nullable<int> tblParadigmaMetodologico_ID { get; set; }
        public string metProy_paradigmaMetodologicoProy { get; set; }
        public Nullable<int> tblParadigmaEpistemologico_ID { get; set; }
        public Nullable<int> tblTipoEstudioProy_ID { get; set; }
        public Nullable<int> tblDisenioProy_ID { get; set; }
        public Nullable<int> tblHistoricoHermeneutico { get; set; }
        public Nullable<int> tblCriticoSocial { get; set; }
        public string metProy_paradigmaEpistemologicoProy { get; set; }
        public string metProy_poblacionMuestraProy { get; set; }
        public string metProy_tecnicasInstrumentosProy { get; set; }
        public string metProy_procedimientoProy { get; set; }
        public string metProy_planAnalisisDatosProy { get; set; }
    
        public virtual tblCriticoSocial tblCriticoSocial1 { get; set; }
        public virtual tblDiseniosProy tblDiseniosProy { get; set; }
        public virtual tblHistoricoHermeneutico tblHistoricoHermeneutico1 { get; set; }
        public virtual tblParadigmaEpistemologico tblParadigmaEpistemologico { get; set; }
        public virtual tblParadigmaMetodologico tblParadigmaMetodologico { get; set; }
        public virtual ICollection<tblProyectosInvestigacion> tblProyectosInvestigacion { get; set; }
        public virtual tblTipoEstudioProy tblTipoEstudioProy { get; set; }
    }
}
