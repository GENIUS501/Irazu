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
    
    public partial class Puestos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Puestos()
        {
            this.Personal = new HashSet<Personal>();
        }
    
        public int Id_Puesto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Salario { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Personal> Personal { get; set; }
    }
}
