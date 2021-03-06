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
    public partial class tblConceptosEstadoArte
    {
        [Display(Name="id")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El Id es obligatorio")]
        [Range(0,int.MaxValue)]
		public int id { get; set; }
		
        [Display(Name= "Estado Arte Id")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El Estado Arte Id es obligatorio")]
        [Range(0,int.MaxValue)]
		public int idEstadoArte { get; set; }
		
        [Display(Name="Autor")]

        [Required(AllowEmptyStrings = false, ErrorMessage = "El Autor es obligatorio")]
        [RegularExpression(@"^[a-zA-Z0-9 ñáéíóúÁÉÍÓÚÑ]+$", ErrorMessage = "Carácter no valido para Autor")]
        [StringLength(255, ErrorMessage = "Máximo 255 caracteres")]
        public string Autor { get; set; }
		
        [Display(Name= "Publicación")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El Publicación es obligatorio")]
        [Range(0,int.MaxValue)]
		public int Publicacion { get; set; }
		
        [Display(Name="Texto")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El Texto es obligatorio")]
        [StringLength(1000, ErrorMessage = "Máximo 1000 caracteres")]
        public string Texto { get; set; }
		
    
        public virtual tblEstadoArteProyectoInvestigacion tblEstadoArteProyectoInvestigacion { get; set; }
    }
}
