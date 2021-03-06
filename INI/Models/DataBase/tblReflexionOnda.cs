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
    public partial class tblReflexionOnda
    {
        [Display(Name="Id")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El Id es obligatorio")]

        [Range(0,int.MaxValue)]
		public int id { get; set; }
		
        [Display(Name= "Introducción")]
        [StringLength(1000, ErrorMessage = "Máximo 1000 caracteres")]


        public string Introduccion { get; set; }
		
        [Display(Name= "Conformación Grupo")]
        [StringLength(1000, ErrorMessage = "Máximo 1000 caracteres")]
        public string ConformacionGrupo { get; set; }
		
        [Display(Name= "Objetivo investigación")]
        [StringLength(1000, ErrorMessage = "Máximo 1000 caracteres")]
        public string ObjetivoInvestigacion { get; set; }
		
        [Display(Name= "Actividades Realizadas")]
        [StringLength(1000, ErrorMessage = "Máximo 1000 caracteres")]
        public string ActividadasRealizadas { get; set; }
		
        [Display(Name= "Conceptos Principales")]
        [StringLength(1000, ErrorMessage = "Máximo 1000 caracteres")]
        public string ConceptosPrincipales { get; set; }
		
        [Display(Name= "Espacios Participación")]
        [StringLength(1000, ErrorMessage = "Máximo 1000 caracteres")]
        public string EspaciosParticipacion { get; set; }
		
        [Display(Name= "Conclusiones")]
        [StringLength(1000, ErrorMessage = "Máximo 1000 caracteres")]
        public string Conclusiones { get; set; }
		
        [Display(Name= "Grupo investigación Id")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El Grupo investigación Id es obligatorio")]

        [Range(0,int.MaxValue)]
		public int idGrupoInvestigacion { get; set; }
		
        [Display(Name= "Fecha Inicio")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> FechaInicio { get; set; }
		
        [Display(Name= "Fecha Fin")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> FechaFin { get; set; }
		
    
        public virtual tblGrupoInvestigacion tblGrupoInvestigacion { get; set; }
    }
}
