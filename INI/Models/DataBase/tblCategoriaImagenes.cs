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
    public partial class tblCategoriaImagenes
    {
        public tblCategoriaImagenes()
        {
            this.tblGaleriaImagenes = new HashSet<tblGaleriaImagenes>();
        }
    
        [Display(Name= "Categoría Id")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El Categoría Id es obligatorio")]
        [Range(0,int.MaxValue)]
		public int cat_ID { get; set; }
		
        [Display(Name= "Nombre Categoría")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El Nombre Categoría es obligatorio")]
        [RegularExpression(@"^[a-zA-Z ñáéíóúÁÉÍÓÚÑ]+$", ErrorMessage = "Carácter no valido para Nombre Categoría")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]

        public string cat_Nombre { get; set; }
		
        [Display(Name= "Categoría Imágenes Portada")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El Categoría Imágenes Portada es obligatoria")]
        [RegularExpression(@"^[a-zA-Z ñáéíóúÁÉÍÓÚÑ]+$", ErrorMessage = "Carácter no valido para Categoría Imágenes Portada")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string cat_Imagen_Portada { get; set; }
		
    
        public virtual ICollection<tblGaleriaImagenes> tblGaleriaImagenes { get; set; }
    }
}
