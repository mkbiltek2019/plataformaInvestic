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
    public partial class tblGaleriaImagenes
    {
        [Display(Name="Imagen Id")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El Imagen Id es obligatorio")]
        [Range(0,int.MaxValue)]
		public int Imagen_ID { get; set; }
		
        [Display(Name="Imagen Título")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El Imagen Título es obligatorio")]
        [RegularExpression(@"^[a-zA-Z ñáéíóúÁÉÍÓÚÑ]+$", ErrorMessage = "Carácter no valido para Imagen Título")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]

        public string Imagen_titulo { get; set; }
		
        [Display(Name= "Imagen Descripción")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "La Imagen Descripción es obligatoria")]
        [RegularExpression(@"^[a-zA-Z ñáéíóúÁÉÍÓÚÑ]+$", ErrorMessage = "Carácter no valido para Imagen Descripción")]
        [StringLength(500, ErrorMessage = "Máximo 500 caracteres")]
        public string Imagen_descripcion { get; set; }
		
        [Display(Name="Imagen Url")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "La Imagen Url es obligatoria")]
        [StringLength(500, ErrorMessage = "Máximo 500 caracteres")]
        public string Imagen_url { get; set; }
		
        [Display(Name= "Categoría Id")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "La Categoría Id es obligatoria")]
        [Range(0,int.MaxValue)]
		public int cat_ID { get; set; }
		
    
        public virtual tblCategoriaImagenes tblCategoriaImagenes { get; set; }
    }
}