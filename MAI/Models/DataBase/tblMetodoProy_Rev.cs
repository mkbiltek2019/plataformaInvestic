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
    
    public partial class tblMetodoProy_Rev
    {
        public tblMetodoProy_Rev()
        {
            this.tblProyectosInvestigacion_Rev = new HashSet<tblProyectosInvestigacion_Rev>();
        }
    
        public long tblMetodoProy_Rev_ID { get; set; }
        public string metProy_paradigmaMetodologicoProy { get; set; }
        public string metProy_paradigmaEpistemologicoProy { get; set; }
        public string metProy_poblacionMuestraProy { get; set; }
        public string metProy_tecnicasInstrumentosProy { get; set; }
        public string metProy_procedimientoProy { get; set; }
        public string metProy_planAnalisisDatosProy { get; set; }
    
        public virtual ICollection<tblProyectosInvestigacion_Rev> tblProyectosInvestigacion_Rev { get; set; }
    }
}
