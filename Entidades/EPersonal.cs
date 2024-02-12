using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EPersonal
    {
        public int ID { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Primer_Apellido { get; set; }
        public string Segundo_Apellido { get; set; }
        public int Genero { get; set; }
        public int Estado { get; set; }
        public Nullable<int> Telefono { get; set; }
        public string Direccion { get; set; }
        public int Id_Puesto { get; set; }
    }
}
