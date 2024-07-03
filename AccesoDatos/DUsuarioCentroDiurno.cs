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
    public class DUsuarioCentroDiurno
    {
        IrazuEntities db = new IrazuEntities();
        EBitacora_Movimientos Entidad_Movimientos = new EBitacora_Movimientos();
        DBitacora_movimientos Movimientos = new DBitacora_movimientos();
        #region Agregar
        public int Agregar(EUsuarioCentroDiurno obj, int Id_Usuario)
        {
            try
            {
                using (TransactionScope Ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    UsuarioCentroDiurno Objbd = new UsuarioCentroDiurno();
                    Objbd.Cedula = obj.Cedula;
                    Objbd.Nombre = obj.Nombre;
                    Objbd.PrimerApellido = obj.PrimerApellido;
                    Objbd.SegundoApellido = obj.SegundoApellido;
                    Objbd.Genero = obj.Genero;
                    Objbd.Estado = true;
                    Objbd.Telefono = obj.Telefono;
                    Objbd.Expediente = obj.Expediente;
                    Objbd.Familiardirecto = obj.Familiardirecto;
                    Objbd.Padecimientos = obj.Padecimientos;
                    Objbd.Medicamentos = obj.Medicamentos;
                    Objbd.Lugarvivienda = obj.Lugarvivienda;
                    Objbd.Fecha_Hora_Ingreso=DateTime.Now;
                    db.UsuarioCentroDiurno.Add(Objbd);

                    int Resultado = db.SaveChanges();

                    if (Resultado > 0)
                    {
                        Ts.Complete();
                        Entidad_Movimientos.Id_Usuario = Id_Usuario;
                        Entidad_Movimientos.modulo = "UsuarioCentroDiurno";
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
        public List<EUsuarioCentroDiurno> Mostrar()
        {
            try
            {
                List<EUsuarioCentroDiurno> Lista = new List<EUsuarioCentroDiurno>();
                Lista = db.UsuarioCentroDiurno
                .Select(x => new EUsuarioCentroDiurno
                {
                    Cedula = x.Cedula,
                    Nombre = x.Nombre,
                    PrimerApellido = x.PrimerApellido,
                    SegundoApellido = x.SegundoApellido,
                    Genero = x.Genero,
                    Telefono = x.Telefono,
                    Expediente = x.Expediente,
                    Familiardirecto = x.Familiardirecto,
                    Padecimientos = x.Padecimientos,
                    Medicamentos = x.Medicamentos,
                    Lugarvivienda = x.Lugarvivienda,
                    ID = x.ID,
                    Fecha_Hora_Ingreso=x.Fecha_Hora_Ingreso,
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
        public int Modificar(EUsuarioCentroDiurno obj, int Id_Usuario)
        {
            try
            {
                using (TransactionScope Ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    var Objbd = db.UsuarioCentroDiurno.Where(x => x.ID == obj.ID).FirstOrDefault();
                    Objbd.Cedula = obj.Cedula;
                    Objbd.Nombre = obj.Nombre;
                    Objbd.PrimerApellido = obj.PrimerApellido;
                    Objbd.SegundoApellido = obj.SegundoApellido;
                    Objbd.Genero = obj.Genero;
                    Objbd.Estado = true;
                    Objbd.Telefono = obj.Telefono;
                    Objbd.Expediente = obj.Expediente;
                    Objbd.Familiardirecto = obj.Familiardirecto;
                    Objbd.Padecimientos = obj.Padecimientos;
                    Objbd.Medicamentos = obj.Medicamentos;
                    Objbd.Lugarvivienda = obj.Lugarvivienda;
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
                        Entidad_Movimientos.modulo = "UsuarioCentroDiurno";
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
                    var Objbd = db.UsuarioCentroDiurno.Where(x => x.ID == ID).FirstOrDefault();
                    db.Entry(Objbd).State = EntityState.Deleted;
                    int Resultado = db.SaveChanges();
                    if (Resultado > 0)
                    {
                        Ts.Complete();
                        Entidad_Movimientos.Id_Usuario = Id_Usuario;
                        Entidad_Movimientos.modulo = "UsuarioCentroDiurno";
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
