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
    
    public partial class Tab_Venta_detallada
    {
        public int Numero_factura { get; set; }
        public int ID_Medicamento { get; set; }
        public int Linea { get; set; }
    
        public virtual Medicamentos Medicamentos { get; set; }
        public virtual Tab_Venta Tab_Venta { get; set; }
    }
}
