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
    public partial class MantenimientoCentroDiurno : Form
    {
        public MantenimientoCentroDiurno()
        {
            InitializeComponent();
        }
        #region Variables
        public int Usuario { get; set; }
        public string Accion { get; set; }
        public int Id { get; set; }
        public bool Egresar { get; set; }
        #endregion
        private void MantenimientoCentroDiurno_Load(object sender, EventArgs e)
        {
            try
            {
                this.cbo_Genero.DisplayMember = "Text";
                this.cbo_Genero.ValueMember = "Value";
                List<dynamic> Generos = new List<dynamic> {
                new { Text = "Femenino", Value = 0 },
                new { Text = "Masculino", Value = 1 }
            };
                var GenerosArray = Generos.Select(x => new { x.Text, x.Value }).ToArray();
                this.cbo_Genero.DataSource = GenerosArray;
                if (Accion == "A")
                {

                }
                if (Accion == "M" || Accion == "C")
                {
                    llenar();
                    if (Accion == "C")
                    {
                        this.grpdatos.Enabled = false;
                        this.GrpOtros.Enabled = false;
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
            NUsuarioCentroDiurno Negocios = new NUsuarioCentroDiurno();
            EUsuarioCentroDiurno Obj = new EUsuarioCentroDiurno();
            Obj = Negocios.Mostrar().Where(x => x.ID == Id).FirstOrDefault();
            this.txt_cedula.Text = Obj.Cedula.ToString();
            this.txt_nombre.Text = Obj.Nombre;
            this.txt_apellido1.Text = Obj.PrimerApellido.ToString();
            this.txt_apellido2.Text = Obj.SegundoApellido.ToString();
            this.TxtNumeroExpediente.Text = Obj.Expediente.ToString();
            this.TxtFamiliar.Text = Obj.Familiardirecto.ToString();
            this.TxtTelefono.Text = Obj.Telefono.ToString();
            this.TxtPadecimientos.Text = Obj.Padecimientos.ToString();
            this.TxtLugar.Text = Obj.Lugarvivienda.ToString();
            this.TxtMedicamentos.Text = Obj.Medicamentos.ToString();
            this.cbo_Genero.SelectedValue = int.Parse(Obj.Genero);
            if (Obj.Fecha_Hora_Salida != null)
            {
                this.txt_fecha_egreso.Text = Obj.Fecha_Hora_Salida.ToString();
                Accion = "C";
            }
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
                if (this.TxtNumeroExpediente.Text == "")
                {
                    errorProvider1.SetError(this.TxtNumeroExpediente, "Debe ingresar el numero de expediente");
                    ok = true;
                }
                if (this.TxtFamiliar.Text == "")
                {
                    errorProvider1.SetError(this.TxtFamiliar, "Debe ingresar el familiar");
                    ok = true;
                }
                if (this.TxtTelefono.Text == "")
                {
                    errorProvider1.SetError(this.TxtTelefono, "Debe ingresar el telefono");
                    ok = true;
                }
                if (this.TxtPadecimientos.Text == "")
                {
                    errorProvider1.SetError(this.TxtPadecimientos, "Debe ingresar los posibles padecimientos");
                    ok = true;
                }
                if (this.TxtLugar.Text == "")
                {
                    errorProvider1.SetError(this.TxtLugar, "Debe ingresar el lugar de vivienda");
                    ok = true;
                }
                if (this.TxtMedicamentos.Text == "")
                {
                    errorProvider1.SetError(this.TxtMedicamentos, "Debe ingresar los medicamentos");
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

                errorProvider1.SetError(this.TxtNumeroExpediente, "");

                errorProvider1.SetError(this.TxtFamiliar, "");

                errorProvider1.SetError(this.TxtTelefono, "");

                errorProvider1.SetError(this.TxtPadecimientos, "");

                errorProvider1.SetError(this.TxtLugar, "");

                errorProvider1.SetError(this.TxtMedicamentos, "");

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
                        NUsuarioCentroDiurno Negocios = new NUsuarioCentroDiurno();
                        EUsuarioCentroDiurno Obj = new EUsuarioCentroDiurno();
                        Obj.Cedula = this.txt_cedula.Text;
                        Obj.Nombre = this.txt_nombre.Text;
                        Obj.PrimerApellido = this.txt_apellido1.Text;
                        Obj.Genero = this.cbo_Genero.SelectedValue.ToString();
                        Obj.SegundoApellido = this.txt_apellido2.Text;
                        Obj.Expediente = this.TxtNumeroExpediente.Text;
                        Obj.Familiardirecto = this.TxtFamiliar.Text;
                        Obj.Telefono = this.TxtTelefono.Text;
                        Obj.Padecimientos = this.TxtPadecimientos.Text;
                        Obj.Lugarvivienda = this.TxtLugar.Text;
                        Obj.Medicamentos = this.TxtMedicamentos.Text;
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
                            if (Egresar)
                            {
                                Obj.Fecha_Hora_Salida = Convert.ToDateTime(this.txt_fecha_egreso.Text);
                            }
                            else
                            {
                                Obj.Fecha_Hora_Salida = null;
                            }
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

        private void btn_egresar_Click(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(this.txt_fecha_egreso.Text.ToString()) > DateTime.Now)
            {
                Egresar = true;
                grpdatos.Enabled = false;
                GrpOtros.Enabled = false;
            }
            else
            {
                MessageBox.Show("La fecha debe ser mayor que la de hoy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
