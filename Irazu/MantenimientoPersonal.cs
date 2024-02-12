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

namespace Lienzos
{
    public partial class MantenimientoPersonal : Form
    {
        public MantenimientoPersonal()
        {
            InitializeComponent();
        }
        #region Variables
        public int Usuario { get; set; }
        public string Accion { get; set; }
        public int Id { get; set; }
        #endregion
        private void MantenimientoPersonal_Load(object sender, EventArgs e)
        {
            try
            {
                #region Puestos
                NPuestos NegociosPuestos = new NPuestos();
                this.cbo_puestos.DisplayMember = "Text";
                this.cbo_puestos.ValueMember = "Value";
                var PuestosDataSource = NegociosPuestos.Mostrar().Select(x => new
                {
                    Text = x.Nombre,
                    Value = x.Id_Puesto
                }
                );
                this.cbo_puestos.DataSource = PuestosDataSource.ToArray();
                #endregion
                #region Genero
                this.cbo_Genero.DisplayMember = "Text";
                this.cbo_Genero.ValueMember = "Value";
                List<dynamic> Generos = new List<dynamic> {
                new { Text = "Femenino", Value = 0 },
                new { Text = "Masculino", Value = 1 }
            };
                var GenerosArray = Generos.Select(x => new { x.Text, x.Value }).ToArray();
                this.cbo_Genero.DataSource = GenerosArray;
                #endregion
                if (Accion == "A")
                {

                }
                if (Accion == "M" || Accion == "C")
                {
                    llenar();
                    if (Accion == "C")
                    {
                        this.grpdatos.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void llenar()
        {
            NPersonal Negocios = new NPersonal();
            EPersonal Obj = new EPersonal();
            Obj = Negocios.Mostrar().Where(x => x.ID == Id).FirstOrDefault();
            this.txt_cedula.Text = Obj.Cedula.ToString();
            this.txt_nombre.Text = Obj.Nombre;
            this.txt_apellido1.Text = Obj.Primer_Apellido.ToString();
            this.cbo_Genero.SelectedValue = Obj.Genero;
            this.txt_apellido2.Text = Obj.Segundo_Apellido.ToString();
            this.TxtDireccion.Text = Obj.Direccion.ToString();
            this.TxtTelefono.Text = Obj.Telefono.ToString();
            this.cbo_puestos.SelectedValue = Obj.Id_Puesto;
        }

        private bool validar()
        {
            bool ok = false;
            try
            {
                if (this.txt_nombre.Text == "")
                {
                    errorProvider1.SetError(this.txt_nombre, "Debe ingresar el nombre");
                    ok = true;
                }
                if (this.txt_apellido1.Text == "")
                {
                    errorProvider1.SetError(this.txt_apellido1, "Debe ingresar el apellido");
                    ok = true;
                }
                if (this.txt_apellido2.Text == "")
                {
                    errorProvider1.SetError(this.txt_apellido2, "Debe ingresar el apellido");
                    ok = true;
                }
                if (this.txt_cedula.Text == "")
                {
                    errorProvider1.SetError(this.txt_cedula, "Debe ingresar la cedula");
                    ok = true;
                }
                if (this.TxtTelefono.Text == "")
                {
                    errorProvider1.SetError(this.TxtTelefono, "Debe ingresar el telefono");
                    ok = true;
                }
                if (this.TxtDireccion.Text == "")
                {
                    errorProvider1.SetError(this.TxtDireccion, "Debe ingresar la direccion");
                    ok = true;
                }
                //
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return ok;
        }
        private void borrar_error()
        {
            try
            {

                errorProvider1.SetError(this.txt_nombre, "");

                errorProvider1.SetError(this.txt_apellido1, "");


                errorProvider1.SetError(this.txt_apellido2, "");

                errorProvider1.SetError(this.txt_cedula, "");

                errorProvider1.SetError(this.TxtDireccion, "");

                errorProvider1.SetError(this.TxtTelefono, "");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion == "C")
                {
                    this.Close();
                }
                borrar_error();
                if (!validar())
                {
                    if (Accion == "A" || Accion == "M")
                    {
                        NPersonal Negocios = new NPersonal();
                        EPersonal Obj = new EPersonal();
                        Obj.Cedula = this.txt_cedula.Text;
                        Obj.Nombre = this.txt_nombre.Text;
                        Obj.Primer_Apellido = this.txt_apellido1.Text;
                        Obj.Genero = int.Parse(this.cbo_Genero.SelectedValue.ToString());
                        Obj.Segundo_Apellido = this.txt_apellido2.Text;
                        Obj.Direccion = this.TxtDireccion.Text;
                        Obj.Telefono = int.Parse(this.TxtTelefono.Text);
                        Int32 FilasAfectadas = 0;
                        #region Agregar
                        if (Accion == "A")
                        {
                            FilasAfectadas = Negocios.Agregar(Obj, Usuario);

                            if (FilasAfectadas > 0)
                            {
                                MessageBox.Show("Usuario de centro diurno Agregado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                if (FilasAfectadas == -1)
                                {
                                    MessageBox.Show("El Usuario de centro diurno se ha agregado exitosamente pero no se a podido registrar la transaccion!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Error al agregar el Usuario de centro diurno!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        #endregion

                        #region Modificar
                        if (Accion == "M")
                        {
                            Obj.ID = Id;
                            FilasAfectadas = Negocios.Modificar(Obj, Usuario);
                            if (FilasAfectadas > 0)
                            {
                                MessageBox.Show("Usuario de centro diurno modificado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                if (FilasAfectadas == -1)
                                {
                                    MessageBox.Show("EL Usuario de centro diurno se ha modificado exitosamente pero no se a podido registrar la transaccion!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Error al modificar la Usuario de centro diurno!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        #endregion
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
