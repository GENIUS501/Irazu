﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EMedicamentos
    {
        public int ID_Medicamento { get; set; }
        public string Nombre { get; set; }
        public string Presentacion { get; set; }
        public int ID_Tipo_Medicamento { get; set; }
        public decimal Concentracion { get; set; }
        public int Cantidad { get; set; }
    }
}
