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
    public partial class AspNetUsers
    {
        public AspNetUsers()
        {
            this.AspNetUserClaims = new HashSet<AspNetUserClaims>();
            this.AspNetUserLogins = new HashSet<AspNetUserLogins>();
            this.AspNetUserRoles = new HashSet<AspNetUserRoles>();
            this.tblActividadContratista = new HashSet<tblActividadContratista>();
            this.tblEquiposTrabajo = new HashSet<tblEquiposTrabajo>();
            this.tblEvidenciasContratista = new HashSet<tblEvidenciasContratista>();
            this.tblProductosContratista = new HashSet<tblProductosContratista>();
            this.tblProgramaTareasContratista = new HashSet<tblProgramaTareasContratista>();
            this.tblResponsabContratista = new HashSet<tblResponsabContratista>();
            this.tblAsesor = new HashSet<tblAsesor>();
            this.tblCoInvestigadorGrupoInvestigacion = new HashSet<tblCoInvestigadorGrupoInvestigacion>();
            this.tblComentarioGrupo = new HashSet<tblComentarioGrupo>();
            this.tblForoProyectoInvestigacion = new HashSet<tblForoProyectoInvestigacion>();
            this.tblGrupoInvestigacion = new HashSet<tblGrupoInvestigacion>();
            this.tblGruposInvestigacion = new HashSet<tblGruposInvestigacion>();
            this.tblHojaVida = new HashSet<tblHojaVida>();
            this.tblIntegrantesGrupoInv = new HashSet<tblIntegrantesGrupoInv>();
            this.tblInvitacionGrupo = new HashSet<tblInvitacionGrupo>();
            this.tblMaestroCoInvestigador = new HashSet<tblMaestroCoInvestigador>();
            this.tblMiembroGrupo = new HashSet<tblMiembroGrupo>();
        }
    
        [Display(Name="Id")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "El Id es obligatorio")]
        //[RegularExpression(@"^[a-zA-Z0-9 ñáéíóúÁÉÍÓÚÑ]+$", ErrorMessage = "Carácter no valido para Id")]
        //[StringLength(128, ErrorMessage = "Máximo 128 caracteres")]
        public string Id { get; set; }
		
        [Display(Name="Nombre")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "El Nombre es obligatorio")]
        //[RegularExpression(@"^[a-zA-Z0-9 ñáéíóúÁÉÍÓÚÑ]+$", ErrorMessage = "Carácter no valido para Nombre")]
        //[StringLength(1000, ErrorMessage = "Máximo 1000 caracteres")]
        public string Name { get; set; }
		
        [Display(Name= "Apellido")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "El Apellido es obligatorio")]
        //[RegularExpression(@"^[a-zA-Z0-9 ñáéíóúÁÉÍÓÚÑ]+$", ErrorMessage = "Carácter no valido para Apellido")]
        //[StringLength(1000, ErrorMessage = "Máximo 1000 caracteres")]
        public string SureName { get; set; }
		
        [Display(Name="Personal ID")]
        //[RegularExpression(@"^[a-zA-Z0-9 ñáéíóúÁÉÍÓÚÑ]+$", ErrorMessage = "Carácter no valido para Apellido")]
        //[StringLength(1000, ErrorMessage = "Máximo 1000 caracteres")]
        public string PersonalID { get; set; }
		
        [Display(Name= "Género")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "El Género es obligatorio")]
        //[Range(0,int.MaxValue)]
		public int Genre { get; set; }
		
        [Display(Name= "Dirección")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "La Dirección es obligatoria")]
        //[RegularExpression(@"^[a-zA-Z0-9 ñáéíóúÁÉÍÓÚÑ#-]+$", ErrorMessage = "Carácter no valido para Dirección")]
        //[StringLength(1000, ErrorMessage = "Máximo 1000 caracteres")]
        public string Address { get; set; }
		
        [Display(Name= "Fecha Nacimiento")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "La Fecha Nacimiento es obligatoria")]
        //[StringLength(10, ErrorMessage = "Máximo 10 caracteres")]
        public System.DateTime BirthDay { get; set; }
		
        [Display(Name="Email")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "El Email es obligatorio")]
        //[RegularExpression(@"^[a-zA-Z0-9 ñáéíóúÁÉÍÓÚÑ]+$", ErrorMessage = "Carácter no valido para Email")]
        //[StringLength(256, ErrorMessage = "Máximo 256 caracteres")]
        public string Email { get; set; }
		
        [Display(Name= "Email Confirmado")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "El Email Confirmado es obligatorio")]
        //[RegularExpression(@"^[a-zA-Z0-9 ñáéíóúÁÉÍÓÚÑ]+$", ErrorMessage = "Carácter no valido para Email Confirmado")]
        public bool EmailConfirmed { get; set; }
		
        [Display(Name= "Contraseña Hash")]
        //[RegularExpression(@"^[a-zA-Z0-9 ñáéíóúÁÉÍÓÚÑ]+$", ErrorMessage = "Carácter no valido para Contraseña Hash")]
        public string PasswordHash { get; set; }
		
        [Display(Name= "Sello de Seguridad")]
        //[RegularExpression(@"^[a-zA-Z0-9 ñáéíóúÁÉÍÓÚÑ]+$", ErrorMessage = "Carácter no valido para Sello de Seguridad")]
        public string SecurityStamp { get; set; }
		
        [Display(Name= "Número de Teléfono")]
        //[RegularExpression(@"^[0-9 ]+$", ErrorMessage = "Carácter no valido para Número de Teléfono")]
        //[StringLength(1000, ErrorMessage = "Máximo 1000 caracteres")]
        public string PhoneNumber { get; set; }
		
        [Display(Name= "Confirmar Número de teléfono")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "El Número de teléfono Confirmar es obligatorio")]
        //[RegularExpression(@"^[0-9 ]+$", ErrorMessage = "Carácter no valido para Email Confirmado")]
        public bool PhoneNumberConfirmed { get; set; }
		
        [Display(Name= "Dos factores Activado")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "El Dos factores Activado es obligatorio")]
        public bool TwoFactorEnabled { get; set; }
		
        [Display(Name= "Fin Fecha Bloqueo Utc")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> LockoutEndDateUtc { get; set; }
		
        [Display(Name= "Bloqueo Habilitado")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "El Bloqueo Habilitado es obligatorio")]
        public bool LockoutEnabled { get; set; }
		
        [Display(Name= "Acceso fallido Error")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "El Acceso es obligatorio")]
        //[Range(0,int.MaxValue)]
		public int AccessFailedCount { get; set; }
		
        [Display(Name= "Nombre de Usuario")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "El Nombre de Usuario es obligatorio")]
        //[RegularExpression(@"^[a-zA-Z0-9 ñáéíóúÁÉÍÓÚÑ]+$", ErrorMessage = "Carácter no valido para Nombre de Usuario")]
        //[StringLength(256, ErrorMessage = "Máximo 256 caracteres")]
        public string UserName { get; set; }
		
        [Display(Name= "Apellido")]
        //[StringLength(1000, ErrorMessage = "Máximo 1000 caracteres")]
        public string LastName { get; set; }
		
        [Display(Name="Celular")]
        //[StringLength(1000, ErrorMessage = "Máximo 1000 caracteres")]
        public string Celular { get; set; }
		
        [Display(Name="Cargo")]
        //[StringLength(1000, ErrorMessage = "Máximo 1000 caracteres")]
        public string Cargo { get; set; }
		
        [Display(Name="Contrato")]
        //[StringLength(1000, ErrorMessage = "Máximo 1000 caracteres")]
        public string Contrato { get; set; }
		
        [Display(Name="Cdp")]
        //[StringLength(1000, ErrorMessage = "Máximo 1000 caracteres")]
        public string Cdp { get; set; }
		
        [Display(Name="Equipo")]
        //[StringLength(1000, ErrorMessage = "Máximo 1000 caracteres")]
        public string Equipo { get; set; }
		
        [Display(Name= "Fecha Inicio Contrato")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> Fecha_IniContrato { get; set; }
		
        [Display(Name="Fecha Fin Contrato")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> Fecha_FinContrato { get; set; }
		
        [Display(Name="Cedula")]
        //[RegularExpression(@"^[0-9 ]+$", ErrorMessage = "Carácter no valido para Cedula")]
        //[StringLength(10, ErrorMessage = "Máximo 10 caracteres")]
        public string Cedula { get; set; }
		
        [Display(Name="Nombres")]
        //[RegularExpression(@"^[a-zA-Z ñáéíóúÁÉÍÓÚÑ]+$", ErrorMessage = "Carácter no valido para Nombres")]
        //[StringLength(1000, ErrorMessage = "Máximo 1000 caracteres")]
        public string Nombres { get; set; }
		
        [Display(Name="Apellidos")]
        //[RegularExpression(@"^[a-zA-Z ñáéíóúÁÉÍÓÚÑ]+$", ErrorMessage = "Carácter no valido para Apellidos")]
        //[StringLength(1000, ErrorMessage = "Máximo 1000 caracteres")]
        public string Apellidos { get; set; }
		
        [Display(Name="TipoDoc")]
        //[Range(0,int.MaxValue)]
		public Nullable<int> TipoDoc { get; set; }
		
    
        public virtual ICollection<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual ICollection<tblActividadContratista> tblActividadContratista { get; set; }
        public virtual ICollection<tblEquiposTrabajo> tblEquiposTrabajo { get; set; }
        public virtual ICollection<tblEvidenciasContratista> tblEvidenciasContratista { get; set; }
        public virtual ICollection<tblProductosContratista> tblProductosContratista { get; set; }
        public virtual ICollection<tblProgramaTareasContratista> tblProgramaTareasContratista { get; set; }
        public virtual ICollection<tblResponsabContratista> tblResponsabContratista { get; set; }
        public virtual ICollection<tblAsesor> tblAsesor { get; set; }
        public virtual ICollection<tblCoInvestigadorGrupoInvestigacion> tblCoInvestigadorGrupoInvestigacion { get; set; }
        public virtual ICollection<tblComentarioGrupo> tblComentarioGrupo { get; set; }
        public virtual ICollection<tblForoProyectoInvestigacion> tblForoProyectoInvestigacion { get; set; }
        public virtual ICollection<tblGrupoInvestigacion> tblGrupoInvestigacion { get; set; }
        public virtual ICollection<tblGruposInvestigacion> tblGruposInvestigacion { get; set; }
        public virtual ICollection<tblHojaVida> tblHojaVida { get; set; }
        public virtual ICollection<tblIntegrantesGrupoInv> tblIntegrantesGrupoInv { get; set; }
        public virtual ICollection<tblInvitacionGrupo> tblInvitacionGrupo { get; set; }
        public virtual ICollection<tblMaestroCoInvestigador> tblMaestroCoInvestigador { get; set; }
        public virtual ICollection<tblMiembroGrupo> tblMiembroGrupo { get; set; }
    }
}
