//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Tab_Venta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tab_Venta()
        {
            this.Tab_Devoluciones = new HashSet<Tab_Devoluciones>();
            this.Tab_Venta_detallada = new HashSet<Tab_Venta_detallada>();
        }
    
        public int ID_Usuario { get; set; }
        public int ID_Cliente { get; set; }
        public string Tipo_pago { get; set; }
        public int Numero_factura { get; set; }
        public double CantidadProducto { get; set; }
        public System.DateTime Fecha_venta { get; set; }
        public double Total { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tab_Devoluciones> Tab_Devoluciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tab_Venta_detallada> Tab_Venta_detallada { get; set; }
        public virtual UsuarioCentroDiurno UsuarioCentroDiurno { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}
