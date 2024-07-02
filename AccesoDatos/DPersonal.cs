using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AccesoDatos
{
    public class DPersonal
    {
        IrazuEntities db = new IrazuEntities();
        EBitacora_Movimientos Entidad_Movimientos = new EBitacora_Movimientos();
        DBitacora_movimientos Movimientos = new DBitacora_movimientos();
        #region Agregar
        public int Agregar(EPersonal obj, int Id_Usuario)
        {
            try
            {
                using (TransactionScope Ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    Personal Objbd = new Personal();
                    Objbd.Cedula = obj.Cedula;
                    Objbd.Nombre = obj.Nombre;
                    Objbd.Primer_Apellido = obj.Primer_Apellido;
                    Objbd.Segundo_Apellido = obj.Segundo_Apellido;
                    Objbd.Genero = obj.Genero;
                    Objbd.Estado = obj.Estado;
                    Objbd.Telefono = obj.Telefono;
                    Objbd.Direccion = obj.Direccion;
                    Objbd.Id_Puesto = obj.Id_Puesto;
                    Objbd.Fecha_Hora_Ingreso=DateTime.Now;
                    db.Personal.Add(Objbd);

                    int Resultado = db.SaveChanges();

                    if (Resultado > 0)
                    {
                        Ts.Complete();
                        Entidad_Movimientos.Id_Usuario = Id_Usuario;
                        Entidad_Movimientos.modulo = "Personal";
                        Entidad_Movimientos.tipo_movimiento = "Agregar";
                        Entidad_Movimientos.fecha_hora_movimiento = DateTime.Now;
                        Movimientos.Agregar(Entidad_Movimientos);
                        return Resultado;
                    }
                    else
                    {
                        Ts.Dispose();
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Mostrar
        public List<EPersonal> Mostrar()
        {
            try
            {
                List<EPersonal> Lista = new List<EPersonal>();
                Lista = db.Personal
                .Select(x => new EPersonal
                {
                    Cedula = x.Cedula,
                    Nombre = x.Nombre,
                    Primer_Apellido = x.Primer_Apellido,
                    Segundo_Apellido = x.Segundo_Apellido,
                    Genero = x.Genero,
                    ID = x.ID,
                    Estado = x.Estado,
                    Telefono = x.Telefono,
                    Direccion = x.Direccion,
                    Id_Puesto = x.Id_Puesto,
                    Fecha_Hora_Salida=x.Fecha_Hora_Salida
                }).ToList();
                return Lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region Modificar
        public int Modificar(EPersonal obj, int Id_Usuario)
        {
            try
            {
                using (TransactionScope Ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    var Objbd = db.Personal.Where(x => x.ID == obj.ID).FirstOrDefault();
                    Objbd.Cedula = obj.Cedula;
                    Objbd.Nombre = obj.Nombre;
                    Objbd.Primer_Apellido = obj.Primer_Apellido;
                    Objbd.Segundo_Apellido = obj.Segundo_Apellido;
                    Objbd.Genero = obj.Genero;
                    Objbd.Estado = obj.Estado;
                    Objbd.Telefono = obj.Telefono;
                    Objbd.Direccion = obj.Direccion;
                    Objbd.Id_Puesto = obj.Id_Puesto;
                    if (obj.Fecha_Hora_Salida != null)
                    {
                        Objbd.Fecha_Hora_Salida = obj.Fecha_Hora_Salida;
                    }
                    db.Entry(Objbd).State = EntityState.Modified;
                    int Resultado = db.SaveChanges();
                    if (Resultado > 0)
                    {
                        Ts.Complete();
                        Entidad_Movimientos.Id_Usuario = Id_Usuario;
                        Entidad_Movimientos.modulo = "Personal";
                        Entidad_Movimientos.tipo_movimiento = "Modificar";
                        Entidad_Movimientos.fecha_hora_movimiento = DateTime.Now;
                        Movimientos.Agregar(Entidad_Movimientos);
                        return Resultado;
                    }
                    Ts.Dispose();
                    return Resultado;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Eliminar
        public int Eliminar(int ID, int Id_Usuario)
        {
            try
            {
                using (TransactionScope Ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    var Objbd = db.Personal.Where(x => x.ID == ID).FirstOrDefault();
                    db.Entry(Objbd).State = EntityState.Deleted;
                    int Resultado = db.SaveChanges();
                    if (Resultado > 0)
                    {
                        Ts.Complete();
                        Entidad_Movimientos.Id_Usuario = Id_Usuario;
                        Entidad_Movimientos.modulo = "Personal";
                        Entidad_Movimientos.tipo_movimiento = "Eliminar";
                        Entidad_Movimientos.fecha_hora_movimiento = DateTime.Now;
                        Movimientos.Agregar(Entidad_Movimientos);
                        return Resultado;
                    }
                    Ts.Dispose();
                    return Resultado;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
