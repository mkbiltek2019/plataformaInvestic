//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace INI.Models.DataBase
{
    using System;
    using System.Collections.Generic;
    
    using System.ComponentModel.DataAnnotations;
    public partial class tblCronogramaProy
    {
        public tblCronogramaProy()
        {
            this.tblFechaCronograma = new HashSet<tblFechaCronograma>();
            this.tblProyectosInvestigacion = new HashSet<tblProyectosInvestigacion>();
        }
    
        [Display(Name= "Cronograma Proyecto Id")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El Cronograma Proyecto Id es obligatorio")]
        public long tblCronogramaProy_ID { get; set; }
		
    
        public virtual ICollection<tblFechaCronograma> tblFechaCronograma { get; set; }
        public virtual ICollection<tblProyectosInvestigacion> tblProyectosInvestigacion { get; set; }
    }
}
