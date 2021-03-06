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
    public partial class tblInstitucionEducativa
    {
        public tblInstitucionEducativa()
        {
            this.tblSedeEducativa = new HashSet<tblSedeEducativa>();
        }
    
        [Display(Name= "Institución Educativa Id")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El Id es obligatorio")]
        [Range(0,int.MaxValue)]
		public int tblInstitucionEducativa_ID { get; set; }
		
        [Display(Name= "Institución Educativa Código Dane")]
        [Range(0,int.MaxValue)]
		public Nullable<int> insEdu_codigoDane { get; set; }
		
        [Display(Name= "Institución Educativa Nombre")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El Institución Educativa Nombre es obligatorio")]
        [RegularExpression(@"^[a-zA-Z0-9 ñáéíóúÁÉÍÓÚÑ]+$", ErrorMessage = "Carácter no valido para Institución Educativa Nombre")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]

        public string insEdu_nombre { get; set; }
		
        [Display(Name= "Institución Educativa Dirección")]
        [StringLength(250, ErrorMessage = "Máximo 250 caracteres")]
        public string insEdu_direccion { get; set; }
		
        [Display(Name= "Institución Educativa Teléfono")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El teléfono es obligatorio")]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        [RegularExpression(@"^[0-9 ]+$", ErrorMessage = "Formato de teléfono no valido")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
        public string insEdu_telefono { get; set; }
		
        [Display(Name= "Institución Educativa Nombre Sede")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "La Institución Educativa Nombre Sede es obligatoria")]
        [RegularExpression(@"^[a-zA-Z0-9 ñáéíóúÁÉÍÓÚÑ]+$", ErrorMessage = "Carácter no valido para Institución Educativa Nombre Sede")]
        [StringLength(250, ErrorMessage = "Máximo 250 caracteres")]

        public string insEdu_nombresede { get; set; }
		
        [Display(Name= "Tipo Establecimiento Id")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El Tipo Establecimiento Id es obligatorio")]
        public long tblTipoEstablecimiento_ID { get; set; }
		
        [Display(Name="Municipio Id")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El Municipio Id es obligatorio")]
        public long tblMunicipio_ID { get; set; }
		
    
        public virtual tblTipoEstablecimiento tblTipoEstablecimiento { get; set; }
        public virtual ICollection<tblSedeEducativa> tblSedeEducativa { get; set; }
    }
}
