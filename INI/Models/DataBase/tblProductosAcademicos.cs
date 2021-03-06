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
    public partial class tblProductosAcademicos
    {
        [Display(Name= "Productos Académicos Id")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El Id es obligatorio")]

        public long tblProductosAcademicos_ID { get; set; }
		
        [Display(Name= "Productos Académicos Título Producto")]
        [StringLength(255, ErrorMessage = "Máximo 255 caracteres")]

        public string proaca_tituloProducto { get; set; }
		
        [Display(Name= "Productos Académicos Terminación")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> proaca_anoTerminacion { get; set; }
		
        [Display(Name= "Categoría Productos Id")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "La Categoría Productos Id es obligatorio")]

        public long tblCategoriaProductos_ID { get; set; }
		
        [Display(Name= "Hoja Vida Id")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El Hoja Vida Id es obligatorio")]

        public long tblHojaVida_ID { get; set; }
		
    
        public virtual tblCategoriaProductos tblCategoriaProductos { get; set; }
        public virtual tblHojaVida tblHojaVida { get; set; }
    }
}
