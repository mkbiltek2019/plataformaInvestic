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
    public partial class AspNetUserClaims
    {
        [Display(Name="Id")]
		[Required]
		[Range(0,int.MaxValue)]
		public int Id { get; set; }
		
        [Display(Name="User Id")]
        [Required]

        public string UserId { get; set; }
		
        [Display(Name="ClaimType")]
        [Required]
        public string ClaimType { get; set; }
		
        [Display(Name="ClaimValue")]
        [Required]
        public string ClaimValue { get; set; }
		
    
        public virtual AspNetUsers AspNetUsers { get; set; }
    }
}
