using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class NTipo_Medicamentos
    {
        #region Agregar
        public int Agregar(ETipo_Medicamentos obj, int Id_Usuario)
        {
            try
            {
                DTipo_Medicamentos db = new DTipo_Medicamentos();
                return db.Agregar(obj, Id_Usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Modificar
        public int Modificar(ETipo_Medicamentos obj, int Id_Usuario)
        {
            try
            {
                DTipo_Medicamentos db = new DTipo_Medicamentos();
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
                DTipo_Medicamentos db = new DTipo_Medicamentos();
                return db.Eliminar(Id, Id_Usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Mostrar
        public List<ETipo_Medicamentos> Mostrar()
        {
            try
            {
                DTipo_Medicamentos db = new DTipo_Medicamentos();
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
