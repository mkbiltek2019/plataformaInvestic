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
    public partial class CategoriaRevista
    {
        public CategoriaRevista()
        {
            this.SubCategoriaRevista = new HashSet<SubCategoriaRevista>();
        }
    
        [Display(Name="Id")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El Id es obligatorio")]
        [RegularExpression(@"^[0-9 ]+$", ErrorMessage = "Carácter no valido para Id")]
        [Range(0,int.MaxValue)]
		public int id { get; set; }

        [Display(Name = "Nombre")]
        [RegularExpression(@"^[a-zA-Z0-9 ñáéíóúÁÉÍÓÚÑ]+$", ErrorMessage = "Carácter no valido para Nombre")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
        public string nombre { get; set; }

        [Display(Name = "Url img")]
        public string urlimg { get; set; }
		
    
        public virtual ICollection<SubCategoriaRevista> SubCategoriaRevista { get; set; }
    }
}