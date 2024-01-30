using Entidades;
using Lienzos;
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
                Personal.Visible = false;
                Medicamentos.Visible = false;
                Tipo_Medicamentos.Visible = false;
                CentroDiurno.Visible = false;
                Reportes.Visible = false;
                Mantenimientos.Visible = false;
                Seguridad.Visible = false;
                Reporte_Personal.Visible = false;
                Reporte_centro_diurno.Visible = false;
                Reporte_Medicamentos.Visible = false;
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
                if (perm.Where(x => x.Modulo == "Medicamentos").FirstOrDefault() != null)
                {
                    Mantenimientos.Visible = true;
                    Medicamentos.Visible = true;
                }
                if (perm.Where(x => x.Modulo == "Personal").FirstOrDefault() != null)
                {
                    Mantenimientos.Visible = true;
                    Personal.Visible = true;
                }
                if (perm.Where(x => x.Modulo == "CentroDiurno").FirstOrDefault() != null)
                {
                    Mantenimientos.Visible = true;
                    CentroDiurno.Visible = true;
                }
                if (perm.Where(x => x.Modulo == "TipoMedicamento").FirstOrDefault() != null)
                {
                    Mantenimientos.Visible = true;
                    Tipo_Medicamentos.Visible = true;
                }
                if (perm.Where(x => x.Modulo == "ReporteMedicamento" || x.Modulo == "ReportePersonal" || x.Modulo == "ReporteCentroDiurno").FirstOrDefault() != null)
                {
                    Reportes.Visible = true;
                }
                if (perm.Where(x => x.Modulo == "ReporteMedicamento").FirstOrDefault() != null)
                {
                    Reporte_Medicamentos.Visible = true;
                }
                if (perm.Where(x => x.Modulo == "ReportePersonal").FirstOrDefault() != null)
                {
                    Reporte_Personal.Visible = true;
                }
                if (perm.Where(x => x.Modulo == "ReporteCentroDiurno").FirstOrDefault() != null)
                {
                    Reporte_centro_diurno.Visible = true;
                }
                if (perm.Where(x => x.Modulo == "BitacoraSesiones").FirstOrDefault() != null)
                {
                    Bitacora_Ingresos.Visible = true;
                }
                if (perm.Where(x => x.Modulo == "BitacoraMovimientos").FirstOrDefault() != null)
                {
                    Bitacora_Movimientos.Visible = true;
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
                showRols.MaximizeBox = false;
                showRols.AutoSizeMode = AutoSizeMode.GrowAndShrink;
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
                frm.MaximizeBox = false;
                frm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
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

        private void Personal_Click(object sender, EventArgs e)
        {
            try
            {
                ListaPersonal frm = new ListaPersonal();
                frm.Usuario = UsuarioLogueado.ID_Usuario;
                frm.Id_Rol = UsuarioLogueado.Id_Rol;
                frm.MaximizeBox = false;
                frm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Medicamentos_Click(object sender, EventArgs e)
        {
            try
            {
                ListaMedicamentos frm = new ListaMedicamentos();
                frm.Usuario = UsuarioLogueado.ID_Usuario;
                frm.Id_Rol = UsuarioLogueado.Id_Rol;
                frm.MaximizeBox = false;
                frm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Tipo_Medicamentos_Click(object sender, EventArgs e)
        {
            try
            {
                ListaTipoMedicamento frm = new ListaTipoMedicamento();
                frm.Usuario = UsuarioLogueado.ID_Usuario;
                frm.Id_Rol = UsuarioLogueado.Id_Rol;
                frm.MaximizeBox = false;
                frm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CentroDiurno_Click(object sender, EventArgs e)
        {
            try
            {
                ListaCentroDiurno frm = new ListaCentroDiurno();
                frm.Usuario = UsuarioLogueado.ID_Usuario;
                frm.Id_Rol = UsuarioLogueado.Id_Rol;
                frm.MaximizeBox = false;
                frm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reporte_Medicamentos_Click(object sender, EventArgs e)
        {
            try
            {
                ReporteMedicamentos frm = new ReporteMedicamentos();
                frm.Usuario = this.UsuarioLogueado.Nombre_Usuario;
                frm.MaximizeBox = false;
                frm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reporte_Personal_Click(object sender, EventArgs e)
        {
            try
            {
                ReportePersonal frm = new ReportePersonal();
                frm.Usuario = this.UsuarioLogueado.Nombre_Usuario;
                frm.MaximizeBox = false;
                frm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reporte_centro_diurno_Click(object sender, EventArgs e)
        {
            try
            {
                ReporteUsuarioCentroDiurno frm = new ReporteUsuarioCentroDiurno();
                frm.Usuario = this.UsuarioLogueado.Nombre_Usuario;
                frm.MaximizeBox = false;
                frm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bitacora_Ingresos_Click(object sender, EventArgs e)
        {
            try
            {
                BitacoraSesiones frm = new BitacoraSesiones();
                frm.Usuariologueado = this.UsuarioLogueado.Nombre_Usuario;
                frm.MaximizeBox = false;
                frm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bitacora_Movimientos_Click(object sender, EventArgs e)
        {
            try
            {
                BitacoraMovimientos frm = new BitacoraMovimientos();
                frm.Usuario = this.UsuarioLogueado.Nombre_Usuario;
                frm.MaximizeBox = false;
                frm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
