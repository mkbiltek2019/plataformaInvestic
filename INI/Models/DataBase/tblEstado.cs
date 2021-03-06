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
    public partial class tblEstado
    {
        public tblEstado()
        {
            this.tblGruposInvestigacion = new HashSet<tblGruposInvestigacion>();
            this.tblProyectosInvestigacion_Rev = new HashSet<tblProyectosInvestigacion_Rev>();
            this.tblProyectosInvestigacion = new HashSet<tblProyectosInvestigacion>();
        }
    
        [Display(Name= "Estado Id")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El Estado Id es obligatorio")]
        public long tblEstado_ID { get; set; }
		
        [Display(Name= "Estado Nombre")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El Estado Nombre es obligatorio")]
        [RegularExpression(@"^[a-zA-Z ñáéíóúÁÉÍÓÚÑ]+$", ErrorMessage = "Carácter no valido para Estado Nombre")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]

        public string est_nombre { get; set; }
		
    
        public virtual ICollection<tblGruposInvestigacion> tblGruposInvestigacion { get; set; }
        public virtual ICollection<tblProyectosInvestigacion_Rev> tblProyectosInvestigacion_Rev { get; set; }
        public virtual ICollection<tblProyectosInvestigacion> tblProyectosInvestigacion { get; set; }
    }
}
