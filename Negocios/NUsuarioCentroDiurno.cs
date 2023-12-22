using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class NUsuarioCentroDiurno
    {
        #region Agregar
        public int Agregar(EUsuarioCentroDiurno obj, int Id_Usuario)
        {
            try
            {
                DUsuarioCentroDiurno db = new DUsuarioCentroDiurno();
                return db.Agregar(obj, Id_Usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Modificar
        public int Modificar(EUsuarioCentroDiurno obj, int Id_Usuario)
        {
            try
            {
                DUsuarioCentroDiurno db = new DUsuarioCentroDiurno();
                return db.Modificar(obj, Id_Usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Eliminar
        public int Eliminar(int Id, int Id_Usuario)
        {
            try
            {
                DUsuarioCentroDiurno db = new DUsuarioCentroDiurno();
                return db.Eliminar(Id, Id_Usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Mostrar
        public List<EUsuarioCentroDiurno> Mostrar()
        {
            try
            {
                DUsuarioCentroDiurno db = new DUsuarioCentroDiurno();
                return db.Mostrar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
