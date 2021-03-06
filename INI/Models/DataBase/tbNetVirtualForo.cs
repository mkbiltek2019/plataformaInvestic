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
    public partial class tbNetVirtualForo
    {
        public tbNetVirtualForo()
        {
            this.tbNetVirtualForo1 = new HashSet<tbNetVirtualForo>();
        }
    
        [Display(Name="id")]
		[Required]
		[Range(0,int.MaxValue)]
		public int id { get; set; }
		
        [Display(Name="idUser")]
		[Required]
		public System.Guid idUser { get; set; }
		
        [Display(Name="idGrupoInvestigacion")]
		[Required]
		[Range(0,int.MaxValue)]
		public int idGrupoInvestigacion { get; set; }
		
        [Display(Name="Titulo")]
		[Required]
		public string Titulo { get; set; }
		
        [Display(Name="Mensaje")]
		[Required]
		public string Mensaje { get; set; }
		
        [Display(Name="Fecha")]
		[Required]
		public System.DateTime Fecha { get; set; }
		
        [Display(Name="Respuestas")]
		[Required]
		[Range(0,int.MaxValue)]
		public int Respuestas { get; set; }
		
        [Display(Name="idForo")]
		[Range(0,int.MaxValue)]
		public Nullable<int> idForo { get; set; }
		
        [Display(Name="FechaUltimaRespuesta")]
		public Nullable<System.DateTime> FechaUltimaRespuesta { get; set; }
		
    
        public virtual ICollection<tbNetVirtualForo> tbNetVirtualForo1 { get; set; }
        public virtual tbNetVirtualForo tbNetVirtualForo2 { get; set; }
        public virtual tbNetVirtualGroup tbNetVirtualGroup { get; set; }
        public virtual tbNetVirtualUser tbNetVirtualUser { get; set; }
    }
}
