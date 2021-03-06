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
    public partial class tblHojaVida
    {
        public tblHojaVida()
        {
            this.tblEventosAcademicos = new HashSet<tblEventosAcademicos>();
            this.tblExperienciaProyectos = new HashSet<tblExperienciaProyectos>();
            this.tblNivelIdioma = new HashSet<tblNivelIdioma>();
            this.tblNivelLengua = new HashSet<tblNivelLengua>();
            this.tblProductosAcademicos = new HashSet<tblProductosAcademicos>();
            this.tblTituloEducacionSuperior = new HashSet<tblTituloEducacionSuperior>();
        }
    
        [Display(Name= "Hoja Vida Id")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "La Hoja Vida Id es obligatoria")]
        public long tblHojaVida_ID { get; set; }
		
        [Display(Name= "Hoja Vida Ano Grado Secundaria")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> hojVid_anoGradoSecundaria { get; set; }
		
        [Display(Name= "Hoja Vida Título Secundaria")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "La Hoja Vida Título Secundariaes obligatorio")]
        [RegularExpression(@"^[a-zA-Z ñáéíóúÁÉÍÓÚÑ]+$", ErrorMessage = "Carácter no valido para Hoja Vida Título Secundaria")]
        [StringLength(255, ErrorMessage = "Máximo 255 caracteres")]

        public string hojVid_tituloSecundaria { get; set; }
		
        [Display(Name= "Usuario Plataforma Id")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El Usuario Plataforma Id es obligatorio")]
        [StringLength(128, ErrorMessage = "Máximo 128 caracteres")]
        public string tblUsuarioPlataforma_ID { get; set; }
		
        [Display(Name= "Hoja Vida Institución Id")]
		[Range(0,int.MaxValue)]
		public Nullable<int> hojVid_Institucion_ID { get; set; }
		
    
        public virtual AspNetUsers AspNetUsers { get; set; }
        public virtual ICollection<tblEventosAcademicos> tblEventosAcademicos { get; set; }
        public virtual ICollection<tblExperienciaProyectos> tblExperienciaProyectos { get; set; }
        public virtual tblInstitucion tblInstitucion { get; set; }
        public virtual ICollection<tblNivelIdioma> tblNivelIdioma { get; set; }
        public virtual ICollection<tblNivelLengua> tblNivelLengua { get; set; }
        public virtual ICollection<tblProductosAcademicos> tblProductosAcademicos { get; set; }
        public virtual ICollection<tblTituloEducacionSuperior> tblTituloEducacionSuperior { get; set; }
    }
}
