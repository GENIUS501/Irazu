using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Irazu
{
    public partial class Principal : Form
    {
        #region Variables
        public int Idsession { get; set; }
        public EUsuario UsuarioLogueado { get; set; }
        #endregion

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            try
            {
                this.Txt_Usuario.Text = UsuarioLogueado.Nombre_Usuario;
                List<EPermisos> perm = new List<EPermisos>();
                NRoles Negocios = new NRoles();
                Usuarios.Visible = false;
                Roles.Visible = false;
                Clientes.Visible = false;
                Productos.Visible = false;
                Tipo_Productos.Visible = false;
                Venta.Visible = false;
                Devolucion.Visible = false;
                Reportes.Visible = false;
                Mantenimientos.Visible = false;
                Seguridad.Visible = false;
                Procesos.Visible = false;
                Reporte_Cliente.Visible = false;
                Reporte_Producto.Visible = false;
                Reporte_Venta.Visible = false;
                Bitacora_Ingresos.Visible = false;
                Bitacora_Movimientos.Visible = false;
                perm = Negocios.llenar_Permisos(UsuarioLogueado.Id_Rol);
                if (perm.Where(x => x.Modulo == "Usuarios").FirstOrDefault() != null)
                {
                    Seguridad.Visible = true;
                    Usuarios.Visible = true;
                }
                if (perm.Where(x => x.Modulo == "Roles").FirstOrDefault() != null)
                {
                    Seguridad.Visible = true;
                    Roles.Visible = true;
                }
                if (perm.Where(x => x.Modulo == "Clientes").FirstOrDefault() != null)
                {
                    Mantenimientos.Visible = true;
                    Clientes.Visible = true;
                }
                if (perm.Where(x => x.Modulo == "Productos").FirstOrDefault() != null)
                {
                    Mantenimientos.Visible = true;
                    Productos.Visible = true;
                }
                if (perm.Where(x => x.Modulo == "Tipo_Producto").FirstOrDefault() != null)
                {
                    Mantenimientos.Visible = true;
                    Tipo_Productos.Visible = true;
                }
                if (perm.Where(x => x.Modulo == "ReporteVentas" || x.Modulo == "ReporteMaquinas" || x.Modulo == "ReporteLoterias" || x.Modulo == "BitacoraSesiones").FirstOrDefault() != null)
                {
                    Reportes.Visible = true;
                }
                if (perm.Where(x => x.Modulo == "ReporteVentas").FirstOrDefault() != null)
                {
                    Reporte_Venta.Visible = true;
                }
                if (perm.Where(x => x.Modulo == "ReporteClientes").FirstOrDefault() != null)
                {
                    Reporte_Cliente.Visible = true;
                }
                if (perm.Where(x => x.Modulo == "ReporteProducto").FirstOrDefault() != null)
                {
                    Reporte_Producto.Visible = true;
                }
                if (perm.Where(x => x.Modulo == "BitacoraSesiones").FirstOrDefault() != null)
                {
                    Bitacora_Ingresos.Visible = true;
                }
                if (perm.Where(x => x.Modulo == "BitacoraMovimientos").FirstOrDefault() != null)
                {
                    Bitacora_Movimientos.Visible = true;
                }
                if (perm.Where(x => x.Modulo == "ProcesoVentas").FirstOrDefault() != null)
                {
                    Procesos.Visible = true;
                    Venta.Visible = true;
                }
                if (perm.Where(x => x.Modulo == "ProcesoDevoluciones").FirstOrDefault() != null)
                {
                    Procesos.Visible = true;
                    Devolucion.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cerrar()
        {
            try
            {
                EBitacora_Sesiones Ses = new EBitacora_Sesiones();
                NBitacora_Sesiones Negocios = new NBitacora_Sesiones();
                Int32 FilasAfectadas;
                Ses.codigo_ingreso_salida = Idsession;
                Ses.fecha_hora_salida = DateTime.Now;
                FilasAfectadas = Negocios.Modificar(Ses);
                if (FilasAfectadas > 0)
                {
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Error al cerrar session!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            try
            {
                Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void reingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                EBitacora_Sesiones Ses = new EBitacora_Sesiones();
                NBitacora_Sesiones Negocios = new NBitacora_Sesiones();
                Int32 FilasAfectadas;
                Ses.codigo_ingreso_salida = Idsession;
                Ses.fecha_hora_salida = DateTime.Now;
                FilasAfectadas = Negocios.Modificar(Ses);
                if (FilasAfectadas > 0)
                {
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("Error al cerrar session!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Restart();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Roles_Click(object sender, EventArgs e)
        {
            try
            {
                ListaRolesyPermisos showRols = new ListaRolesyPermisos();
                showRols.Usuario = UsuarioLogueado.ID_Usuario;
                showRols.Id_Rol = UsuarioLogueado.Id_Rol;
                showRols.MdiParent = this;
                showRols.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Usuarios_Click(object sender, EventArgs e)
        {
            try
            {
                ListarUsuarios frm = new ListarUsuarios();
                frm.Usuario = UsuarioLogueado.ID_Usuario;
                frm.Id_Rol = UsuarioLogueado.Id_Rol;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
