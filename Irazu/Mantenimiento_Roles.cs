﻿using Entidades;
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
    public partial class Mantenimiento_Roles : Form
    {
        public int Usuario { get; set; }
        public int Id { get; set; }
        public string Accion { get; set; }
        public Mantenimiento_Roles()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                BorrarMensajesError();
                if (this.ValidarCampos())
                {
                    if (Accion == "A" || Accion == "M")
                    {
                        NRoles Negocios = new NRoles();
                        ERoles Rol = new ERoles();
                        Int32 FilasAfectadas = 0;
                        Rol.Nombre_Rol = this.txt_nombre_perfil.Text;
                        Rol.Descripcion = this.txt_nombre_perfil.Text;
                        if (Accion == "A")
                        {
                            FilasAfectadas = Negocios.Agregar(Rol, Usuario);
                            if (FilasAfectadas > 0)
                            {
                                var Permi = Permisos(FilasAfectadas);
                                Negocios.AgregarPermisos(Permi, FilasAfectadas);
                                MessageBox.Show("Rol agregado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Error al agregar el rol!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        if (Accion == "M")
                        {
                            Rol.Id_Rol = int.Parse(this.txt_id_perfil.Text);
                            FilasAfectadas = Negocios.Modificar(Rol, Usuario);
                            var Permi = Permisos(int.Parse(this.txt_id_perfil.Text));
                            Negocios.AgregarPermisos(Permi, int.Parse(this.txt_id_perfil.Text));
                            MessageBox.Show("Rol modificado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    if (Accion == "C")
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Mantenimiento_Roles_Load(object sender, EventArgs e)
        {
            try
            {
                if (Accion == "A")
                {
                    this.Lbl_Perfil.Visible = false;
                    this.txt_id_perfil.Visible = false;
                }
                if (Accion == "M" || Accion == "C")
                {
                    Llenar();
                    this.txt_id_perfil.Enabled = false;
                    if (Accion == "C")
                    {
                        this.groupBox1.Enabled = false;
                        this.groupBox2.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region llenar Permisos
        private void Llenar()
        {
            try
            {
                NRoles Negocios = new NRoles();
                List<EPermisos> Permisos = new List<EPermisos>();
                ERoles Rol = new ERoles();
                Permisos = Negocios.llenar_Permisos(Id);
                Rol = Negocios.Mostrar().Where(x => x.Id_Rol == Id).FirstOrDefault();
                this.txt_id_perfil.Text = Rol.Id_Rol.ToString();
                this.txt_nombre_perfil.Text = Rol.Nombre_Rol.ToString();
                #region Roles 1
                ////////Roles//1////////////////////////////////////
                if (Permisos.Where(x => x.Modulo == "Roles").FirstOrDefault() != null)
                {
                    this.grp_roles.Enabled = true;
                    this.chb_rol.Checked = true;
                    if (Permisos.Where(x => x.Modulo == "Roles" && x.Accion == "Agregar").FirstOrDefault() != null)
                    {
                        this.chk_rol_agregar.Checked = true;
                    }
                    else
                    {
                        this.chk_rol_agregar.Checked = false;
                    }
                    ///
                    if (Permisos.Where(x => x.Modulo == "Roles" && x.Accion == "Consultar").FirstOrDefault() != null)
                    {
                        this.chk_rol_consultar.Checked = true;
                    }
                    else
                    {
                        this.chk_rol_consultar.Checked = false;
                    }
                    /////
                    if (Permisos.Where(x => x.Modulo == "Roles" && x.Accion == "Eliminar").FirstOrDefault() != null)
                    {
                        this.chk_rol_eliminar.Checked = true;
                    }
                    else
                    {
                        this.chk_rol_eliminar.Checked = false;
                    }
                    /////
                    if (Permisos.Where(x => x.Modulo == "Roles" && x.Accion == "Modificar").FirstOrDefault() != null)
                    {
                        this.chk_rol_modificar.Checked = true;
                    }
                    else
                    {
                        this.chk_rol_modificar.Checked = false;
                    }
                }
                else
                {

                }
                #endregion
                #region Usuarios 2
                ////////Usuarios//2////////////////////////////////////
                if (Permisos.Where(x => x.Modulo == "Usuarios").FirstOrDefault() != null)
                {
                    this.grp_usuarios.Enabled = true;
                    this.chb_usuarios.Checked = true;
                    if (Permisos.Where(x => x.Modulo == "Usuarios" && x.Accion == "Agregar").FirstOrDefault() != null)
                    {
                        this.chk_usuarios_agregar.Checked = true;
                    }
                    else
                    {
                        this.chk_usuarios_agregar.Checked = false;
                    }
                    ///
                    if (Permisos.Where(x => x.Modulo == "Usuarios" && x.Accion == "Consultar").FirstOrDefault() != null)
                    {
                        this.chk_usuarios_consultar.Checked = true;
                    }
                    else
                    {
                        this.chk_usuarios_consultar.Checked = false;
                    }
                    /////
                    if (Permisos.Where(x => x.Modulo == "Usuarios" && x.Accion == "Eliminar").FirstOrDefault() != null)
                    {
                        this.chk_usuarios_eliminar.Checked = true;
                    }
                    else
                    {
                        this.chk_usuarios_eliminar.Checked = false;
                    }
                    /////
                    if (Permisos.Where(x => x.Modulo == "Usuarios" && x.Accion == "Modificar").FirstOrDefault() != null)
                    {
                        this.chk_usuarios_modificar.Checked = true;
                    }
                    else
                    {
                        this.chk_usuarios_modificar.Checked = false;
                    }
                }
                else
                {

                }
                #endregion
                #region CentroDiurno 3
                ////////CentroDiurno//3////////////////////////////////////
                if (Permisos.Where(x => x.Modulo == "CentroDiurno").FirstOrDefault() != null)
                {
                    this.grp_Centro_Diurno.Enabled = true;
                    this.chb_Centro_Diurno.Checked = true;
                    if (Permisos.Where(x => x.Modulo == "CentroDiurno" && x.Accion == "Agregar").FirstOrDefault() != null)
                    {
                        this.chk_Centro_Diurno_agregar.Checked = true;
                    }
                    else
                    {
                        this.chk_Centro_Diurno_agregar.Checked = false;
                    }
                    ///
                    if (Permisos.Where(x => x.Modulo == "CentroDiurno" && x.Accion == "Consultar").FirstOrDefault() != null)
                    {
                        this.chk_Centro_Diurno_consultar.Checked = true;
                    }
                    else
                    {
                        this.chk_Centro_Diurno_consultar.Checked = false;
                    }
                    /////
                    if (Permisos.Where(x => x.Modulo == "CentroDiurno" && x.Accion == "Eliminar").FirstOrDefault() != null)
                    {
                        this.chk_Centro_Diurno_eliminar.Checked = true;
                    }
                    else
                    {
                        this.chk_Centro_Diurno_eliminar.Checked = false;
                    }
                    /////
                    if (Permisos.Where(x => x.Modulo == "CentroDiurno" && x.Accion == "Modificar").FirstOrDefault() != null)
                    {
                        this.chk_Centro_Diurno_modificar.Checked = true;
                    }
                    else
                    {
                        this.chk_Centro_Diurno_modificar.Checked = false;
                    }
                }
                else
                {

                }
                #endregion
                #region Personal
                ////////Personal//////////////////////////////////////
                if (Permisos.Where(x => x.Modulo == "Personal").FirstOrDefault() != null)
                {
                    this.grp_personal.Enabled = true;
                    this.chb_Personal.Checked = true;
                    if (Permisos.Where(x => x.Modulo == "Personal" && x.Accion == "Agregar").FirstOrDefault() != null)
                    {
                        this.chk_personal_agregar.Checked = true;
                    }
                    else
                    {
                        this.chk_personal_agregar.Checked = false;
                    }
                    ///
                    if (Permisos.Where(x => x.Modulo == "Personal" && x.Accion == "Consultar").FirstOrDefault() != null)
                    {
                        this.chk_personal_consultar.Checked = true;
                    }
                    else
                    {
                        this.chk_personal_consultar.Checked = false;
                    }
                    /////
                    if (Permisos.Where(x => x.Modulo == "Personal" && x.Accion == "Eliminar").FirstOrDefault() != null)
                    {
                        this.chk_personal_eliminar.Checked = true;
                    }
                    else
                    {
                        this.chk_personal_eliminar.Checked = false;
                    }
                    /////
                    if (Permisos.Where(x => x.Modulo == "Personal" && x.Accion == "Modificar").FirstOrDefault() != null)
                    {
                        this.chk_personal_modificar.Checked = true;
                    }
                    else
                    {
                        this.chk_personal_modificar.Checked = false;
                    }
                }
                else
                {

                }
                #endregion
                #region Medicamentos 5
                ////////Productos//5////////////////////////////////////
                if (Permisos.Where(x => x.Modulo == "Medicamentos").FirstOrDefault() != null)
                {
                    this.grp_medicamentos.Enabled = true;
                    this.chb_medicamentos.Checked = true;
                    if (Permisos.Where(x => x.Modulo == "Medicamentos" && x.Accion == "Agregar").FirstOrDefault() != null)
                    {
                        this.chk_medicamentos_agregar.Checked = true;
                    }
                    else
                    {
                        this.chk_medicamentos_agregar.Checked = false;
                    }
                    ///
                    if (Permisos.Where(x => x.Modulo == "Medicamentos" && x.Accion == "Consultar").FirstOrDefault() != null)
                    {
                        this.chk_medicamentos_consultar.Checked = true;
                    }
                    else
                    {
                        this.chk_medicamentos_consultar.Checked = false;
                    }
                    /////
                    if (Permisos.Where(x => x.Modulo == "Medicamentos" && x.Accion == "Eliminar").FirstOrDefault() != null)
                    {
                        this.chk_medicamentos_eliminar.Checked = true;
                    }
                    else
                    {
                        this.chk_medicamentos_eliminar.Checked = false;
                    }
                    /////
                    if (Permisos.Where(x => x.Modulo == "Medicamentos" && x.Accion == "Modificar").FirstOrDefault() != null)
                    {
                        this.chk_medicamentos_modificar.Checked = true;
                    }
                    else
                    {
                        this.chk_medicamentos_modificar.Checked = false;
                    }
                }
                else
                {

                }
                #endregion
                #region TipoTipoMedicamento 5
                ////////Productos//5////////////////////////////////////
                if (Permisos.Where(x => x.Modulo == "TipoMedicamento").FirstOrDefault() != null)
                {
                    this.grp_TipoMedicamento.Enabled = true;
                    this.chb_Tipo_Mediacamento.Checked = true;
                    if (Permisos.Where(x => x.Modulo == "TipoMedicamento" && x.Accion == "Agregar").FirstOrDefault() != null)
                    {
                        this.chk_Tipo_Mediacamento_Agregar.Checked = true;
                    }
                    else
                    {
                        this.chk_Tipo_Mediacamento_Agregar.Checked = false;
                    }
                    ///
                    if (Permisos.Where(x => x.Modulo == "TipoMedicamento" && x.Accion == "Consultar").FirstOrDefault() != null)
                    {
                        this.chk_Tipo_Mediacamento_Consultar.Checked = true;
                    }
                    else
                    {
                        this.chk_Tipo_Mediacamento_Consultar.Checked = false;
                    }
                    /////
                    if (Permisos.Where(x => x.Modulo == "TipoMedicamento" && x.Accion == "Eliminar").FirstOrDefault() != null)
                    {
                        this.chk_Tipo_Mediacamento_eliminar.Checked = true;
                    }
                    else
                    {
                        this.chk_Tipo_Mediacamento_eliminar.Checked = false;
                    }
                    /////
                    if (Permisos.Where(x => x.Modulo == "TipoMedicamento" && x.Accion == "Modificar").FirstOrDefault() != null)
                    {
                        this.chk_Tipo_Mediacamento_Modificar.Checked = true;
                    }
                    else
                    {
                        this.chk_Tipo_Mediacamento_Modificar.Checked = false;
                    }
                }
                else
                {

                }
                #endregion
                #region Puestos
                ////////Productos//////////////////////////////////////
                if (Permisos.Where(x => x.Modulo == "Puestos").FirstOrDefault() != null)
                {
                    this.grp_Puestos.Enabled = true;
                    this.chb_Puestos.Checked = true;
                    if (Permisos.Where(x => x.Modulo == "Puestos" && x.Accion == "Agregar").FirstOrDefault() != null)
                    {
                        this.chk_Puestos_Agregar.Checked = true;
                    }
                    else
                    {
                        this.chk_Puestos_Agregar.Checked = false;
                    }
                    ///
                    if (Permisos.Where(x => x.Modulo == "Puestos" && x.Accion == "Consultar").FirstOrDefault() != null)
                    {
                        this.chk_Puestos_Consultar.Checked = true;
                    }
                    else
                    {
                        this.chk_Puestos_Consultar.Checked = false;
                    }
                    /////
                    if (Permisos.Where(x => x.Modulo == "Puestos" && x.Accion == "Eliminar").FirstOrDefault() != null)
                    {
                        this.chk_Puestos_Eliminar.Checked = true;
                    }
                    else
                    {
                        this.chk_Puestos_Eliminar.Checked = false;
                    }
                    /////
                    if (Permisos.Where(x => x.Modulo == "Puestos" && x.Accion == "Modificar").FirstOrDefault() != null)
                    {
                        this.chk_Puestos_Modificar.Checked = true;
                    }
                    else
                    {
                        this.chk_Puestos_Modificar.Checked = false;
                    }
                }
                else
                {

                }
                #endregion
                #region Reporte de medicamentos
                if (Permisos.Where(x => x.Modulo == "ReporteMedicamento").FirstOrDefault() != null)
                {
                    this.chb_Medicamentos_reporte.Checked = true;
                }
                else
                {

                }
                #endregion
                #region Reporte de personal
                if (Permisos.Where(x => x.Modulo == "ReportePersonal").FirstOrDefault() != null)
                {
                    this.chb_reporte_personal.Checked = true;
                }
                else
                {

                }
                #endregion
                #region Reporte de usuario centro diurno
                if (Permisos.Where(x => x.Modulo == "ReporteCentroDiurno").FirstOrDefault() != null)
                {
                    this.chb_reporte_centro_diurno.Checked = true;
                }
                else
                {

                }
                #endregion
                #region Reporte de planillas
                if (Permisos.Where(x => x.Modulo == "ReportePlanilla").FirstOrDefault() != null)
                {
                    this.chb_reporte_planillas.Checked = true;
                }
                else
                {

                }
                #endregion
                #region Bitacora de sesiones
                if (Permisos.Where(x => x.Modulo == "BitacoraSesiones").FirstOrDefault() != null)
                {
                    this.chb_bit_sesiones.Checked = true;
                }
                else
                {

                }
                #endregion              
                #region Bitacora de Movimientos
                if (Permisos.Where(x => x.Modulo == "BitacoraMovimientos").FirstOrDefault() != null)
                {
                    this.chb_bit_movimientos.Checked = true;
                }
                else
                {

                }
                #endregion
                #region Procesos
                if (Permisos.Where(x => x.Modulo == "ProcesoVentas").FirstOrDefault() != null)
                {
                    this.chb_ventas.Checked = true;
                }
                else
                {

                }
                if (Permisos.Where(x => x.Modulo == "ProcesoDevoluciones").FirstOrDefault() != null)
                {
                    this.chb_devoluciones.Checked = true;
                }
                else
                {

                }
                #endregion

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Agregar Permisos
        private List<EPermisos> Permisos(int Id_Rol)
        {
            try
            {
                List<EPermisos> Lista_Permisos = new List<EPermisos>();
                EPermisos Permisos = new EPermisos();
                ///////////////////Roles/////////////////////////////////////////////////////////////////////////////
                if (this.chb_rol.Checked == true)
                {
                    Permisos.Id_Rol = Id_Rol;
                    Permisos.Modulo = "Roles";
                    Permisos.Accion = "Roles";
                    Lista_Permisos.Add(Permisos);
                    Permisos = new EPermisos();
                    if (this.grp_roles.Enabled == true)
                    {
                        if (chk_rol_agregar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Roles";
                            Permisos.Accion = "Agregar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_rol_modificar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Roles";
                            Permisos.Accion = "Modificar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_rol_eliminar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Roles";
                            Permisos.Accion = "Eliminar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_rol_consultar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Roles";
                            Permisos.Accion = "Consultar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                    }
                }

                /////////Usuarios/////////////////////////////////////////////////////////////////////////////
                if (this.chb_usuarios.Checked == true)
                {
                    Permisos.Id_Rol = Id_Rol;
                    Permisos.Modulo = "Usuarios";
                    Permisos.Accion = "Usuarios";
                    Lista_Permisos.Add(Permisos);
                    Permisos = new EPermisos();
                    if (this.grp_usuarios.Enabled == true)
                    {
                        if (chk_usuarios_agregar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Usuarios";
                            Permisos.Accion = "Agregar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_usuarios_modificar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Usuarios";
                            Permisos.Accion = "Modificar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_usuarios_eliminar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Usuarios";
                            Permisos.Accion = "Eliminar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_usuarios_consultar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Usuarios";
                            Permisos.Accion = "Consultar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                    }
                }
                /////////Personal//////3///////////////////////////////////////////////////////////////////////
                if (this.chb_Personal.Checked == true)
                {
                    Permisos.Id_Rol = Id_Rol;
                    Permisos.Modulo = "Personal";
                    Permisos.Accion = "Personal";
                    Lista_Permisos.Add(Permisos);
                    Permisos = new EPermisos();
                    if (this.grp_personal.Enabled == true)
                    {
                        if (chk_personal_agregar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Personal";
                            Permisos.Accion = "Agregar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_personal_modificar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Personal";
                            Permisos.Accion = "Modificar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_personal_eliminar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Personal";
                            Permisos.Accion = "Eliminar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_personal_consultar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Personal";
                            Permisos.Accion = "Consultar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                    }
                }
                /////////Medicamentos/////////////////////////////////////////////////////////////////////////////
                if (this.chb_medicamentos.Checked == true)
                {
                    Permisos.Id_Rol = Id_Rol;
                    Permisos.Modulo = "Medicamentos";
                    Permisos.Accion = "Medicamentos";
                    Lista_Permisos.Add(Permisos);
                    Permisos = new EPermisos();
                    if (this.grp_medicamentos.Enabled == true)
                    {
                        if (chk_medicamentos_agregar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Medicamentos";
                            Permisos.Accion = "Agregar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_medicamentos_modificar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Medicamentos";
                            Permisos.Accion = "Modificar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_medicamentos_eliminar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Medicamentos";
                            Permisos.Accion = "Eliminar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_medicamentos_consultar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Medicamentos";
                            Permisos.Accion = "Consultar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                    }
                }
                /////////CentroDiurno//////5///////////////////////////////////////////////////////////////////////
                if (this.chb_Centro_Diurno.Checked == true)
                {
                    Permisos.Id_Rol = Id_Rol;
                    Permisos.Modulo = "CentroDiurno";
                    Permisos.Accion = "CentroDiurno";
                    Lista_Permisos.Add(Permisos);
                    Permisos = new EPermisos();
                    if (this.grp_Centro_Diurno.Enabled == true)
                    {
                        if (chk_Centro_Diurno_agregar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "CentroDiurno";
                            Permisos.Accion = "Agregar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_Centro_Diurno_modificar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "CentroDiurno";
                            Permisos.Accion = "Modificar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_Centro_Diurno_eliminar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "CentroDiurno";
                            Permisos.Accion = "Eliminar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_Centro_Diurno_consultar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "CentroDiurno";
                            Permisos.Accion = "Consultar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                    }
                }
                /////////Tipo_Mediacamento//////6///////////////////////////////////////////////////////////////////////
                if (this.chb_Tipo_Mediacamento.Checked == true)
                {
                    Permisos.Id_Rol = Id_Rol;
                    Permisos.Modulo = "TipoMedicamento";
                    Permisos.Accion = "TipoMedicamento";
                    Lista_Permisos.Add(Permisos);
                    Permisos = new EPermisos();
                    if (this.grp_TipoMedicamento.Enabled == true)
                    {
                        if (chk_Tipo_Mediacamento_Agregar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "TipoMedicamento";
                            Permisos.Accion = "Agregar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_Tipo_Mediacamento_Modificar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "TipoMedicamento";
                            Permisos.Accion = "Modificar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_Tipo_Mediacamento_eliminar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "TipoMedicamento";
                            Permisos.Accion = "Eliminar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_Tipo_Mediacamento_Consultar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "TipoMedicamento";
                            Permisos.Accion = "Consultar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                    }
                }
                /////////Puestos//////6///////////////////////////////////////////////////////////////////////
                if (this.chb_Puestos.Checked == true)
                {
                    Permisos.Id_Rol = Id_Rol;
                    Permisos.Modulo = "Puestos";
                    Permisos.Accion = "Puestos";
                    Lista_Permisos.Add(Permisos);
                    Permisos = new EPermisos();
                    if (this.grp_Puestos.Enabled == true)
                    {
                        if (chk_Puestos_Agregar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Puestos";
                            Permisos.Accion = "Agregar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_Puestos_Modificar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Puestos";
                            Permisos.Accion = "Modificar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_Puestos_Eliminar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Puestos";
                            Permisos.Accion = "Eliminar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_Puestos_Consultar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Puestos";
                            Permisos.Accion = "Consultar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                    }
                }
                ////////Reportes_Medicamentos////10///////////////////////
                if (this.chb_Medicamentos_reporte.Checked == true)
                {
                    Permisos.Id_Rol = Id_Rol;
                    Permisos.Modulo = "ReporteMedicamento";
                    Permisos.Accion = "ReporteMedicamento";
                    Lista_Permisos.Add(Permisos);
                    Permisos = new EPermisos();
                }
                ////////Reportes_Personal////10//////////////////////////////////////////////////////////////////////////////////
                if (this.chb_reporte_personal.Checked == true)
                {
                    Permisos.Id_Rol = Id_Rol;
                    Permisos.Modulo = "ReportePersonal";
                    Permisos.Accion = "ReportePersonal";
                    Lista_Permisos.Add(Permisos);
                    Permisos = new EPermisos();
                }
                ////////Reporte_Ventas//////////////////////////////////////////////////////////////////////////////////////
                if (this.chb_reporte_centro_diurno.Checked == true)
                {
                    Permisos.Id_Rol = Id_Rol;
                    Permisos.Modulo = "ReporteCentroDiurno";
                    Permisos.Accion = "ReporteCentroDiurno";
                    Lista_Permisos.Add(Permisos);
                    Permisos = new EPermisos();
                }
                ////////Reporte_Planillas//////////////////////////////////////////////////////////////////////////////////////
                if (this.chb_reporte_planillas.Checked == true)
                {
                    Permisos.Id_Rol = Id_Rol;
                    Permisos.Modulo = "ReportePlanilla";
                    Permisos.Accion = "ReportePlanilla";
                    Lista_Permisos.Add(Permisos);
                    Permisos = new EPermisos();
                }
                ////////Bitacora_sesiones//////////////////////////////////////////////////////////////////////////////////////
                if (this.chb_bit_sesiones.Checked == true)
                {
                    Permisos.Id_Rol = Id_Rol;
                    Permisos.Modulo = "BitacoraSesiones";
                    Permisos.Accion = "BitacoraSesiones";
                    Lista_Permisos.Add(Permisos);
                    Permisos = new EPermisos();
                }
                ////////Bitacora_movimientos//////////////////////////////////////////////////////////////////////////////////////
                if (this.chb_bit_movimientos.Checked == true)
                {
                    Permisos.Id_Rol = Id_Rol;
                    Permisos.Modulo = "BitacoraMovimientos";
                    Permisos.Accion = "BitacoraMovimientos";
                    Lista_Permisos.Add(Permisos);
                    Permisos = new EPermisos();
                }
                ///////////////////////////////////////////////
                if (this.chb_ventas.Checked == true)
                {
                    Permisos.Id_Rol = Id_Rol;
                    Permisos.Modulo = "ProcesoVentas";
                    Permisos.Accion = "ProcesoVentas";
                    Lista_Permisos.Add(Permisos);
                    Permisos = new EPermisos();
                }
                ///////////////////////////////////////////////
                if (this.chb_devoluciones.Checked == true)
                {
                    Permisos.Id_Rol = Id_Rol;
                    Permisos.Modulo = "ProcesoDevoluciones";
                    Permisos.Accion = "ProcesoDevoluciones";
                    Lista_Permisos.Add(Permisos);
                    Permisos = new EPermisos();
                }
                return Lista_Permisos;
            }
            catch (Exception)
            {
                return new List<EPermisos>();
            }
        }
        #endregion
        private void BorrarMensajesError()
        {
            try
            {
                errorProvider1.SetError(txt_nombre_perfil, "");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        private bool ValidarCampos()
        {
            try
            {
                bool ok = true;

                if (txt_nombre_perfil.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(txt_nombre_perfil, "Ingrese el nombre del perfil");
                }

                return ok;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void chb_rol_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chb_rol.Checked == true)
                {
                    grp_roles.Enabled = true;
                }
                else
                {
                    grp_roles.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chb_usuarios_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chb_usuarios.Checked == true)
                {
                    grp_usuarios.Enabled = true;
                }
                else
                {
                    grp_usuarios.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chb_Personal_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chb_Personal.Checked == true)
                {
                    grp_personal.Enabled = true;
                }
                else
                {
                    grp_personal.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chb_Puestos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chb_Puestos.Checked == true)
                {
                    grp_Puestos.Enabled = true;
                }
                else
                {
                    grp_Puestos.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chb_Productos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chb_medicamentos.Checked == true)
                {
                    grp_medicamentos.Enabled = true;
                }
                else
                {
                    grp_medicamentos.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chb_CentroDiurno_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chb_Centro_Diurno.Checked == true)
                {
                    grp_Centro_Diurno.Enabled = true;
                }
                else
                {
                    grp_Centro_Diurno.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chb_Tipo_Mediacamento_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chb_Tipo_Mediacamento.Checked == true)
                {
                    grp_TipoMedicamento.Enabled = true;
                }
                else
                {
                    grp_TipoMedicamento.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
