﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoDatos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IrazuEntities : DbContext
    {
        public IrazuEntities()
            : base("name=IrazuEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bitacora_Movimientos> Bitacora_Movimientos { get; set; }
        public virtual DbSet<Bitacora_Sesiones> Bitacora_Sesiones { get; set; }
        public virtual DbSet<Medicamentos> Medicamentos { get; set; }
        public virtual DbSet<Permisos> Permisos { get; set; }
        public virtual DbSet<Personal> Personal { get; set; }
        public virtual DbSet<Puestos> Puestos { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Tab_Devoluciones> Tab_Devoluciones { get; set; }
        public virtual DbSet<Tab_Venta> Tab_Venta { get; set; }
        public virtual DbSet<Tab_Venta_detallada> Tab_Venta_detallada { get; set; }
        public virtual DbSet<Tipo_Medicamentos> Tipo_Medicamentos { get; set; }
        public virtual DbSet<UsuarioCentroDiurno> UsuarioCentroDiurno { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
    }
}
