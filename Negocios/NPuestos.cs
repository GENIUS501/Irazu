using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
   public class NPuestos
    {
        #region Agregar
        public int Agregar(EPuestos obj, int Id_Usuario)
        {
            try
            {
                DPuestos db = new DPuestos();
                return db.Agregar(obj, Id_Usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Modificar
        public int Modificar(EPuestos obj, int Id_Usuario)
        {
            try
            {
                DPuestos db = new DPuestos();
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
                DPuestos db = new DPuestos();
                return db.Eliminar(Id, Id_Usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Mostrar
        public List<EPuestos> Mostrar()
        {
            try
            {
                DPuestos db = new DPuestos();
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
