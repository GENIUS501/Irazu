using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EUsuarioCentroDiurno
    {
        public int ID { get; set; }
        public string Expediente { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Genero { get; set; }
        public string Familiardirecto { get; set; }
        public string Lugarvivienda { get; set; }
        public string Padecimientos { get; set; }
        public string Medicamentos { get; set; }
        public Nullable<bool> Estado { get; set; }
        public string Telefono { get; set; }
    }
}
