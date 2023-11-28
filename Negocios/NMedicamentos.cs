using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class NMedicamentos
    {
        #region Agregar
        public int Agregar(EMedicamentos obj, int Id_Usuario)
        {
            try
            {
                DMedicamentos db = new DMedicamentos();
                return db.Agregar(obj, Id_Usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Modificar
        public int Modificar(EMedicamentos obj, int Id_Usuario)
        {
            try
            {
                DMedicamentos db = new DMedicamentos();
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
                DMedicamentos db = new DMedicamentos();
                return db.Eliminar(Id, Id_Usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Mostrar
        public List<EMedicamentos> Mostrar()
        {
            try
            {
                DMedicamentos db = new DMedicamentos();
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
