using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lienzos
{
    public partial class MantenimientoMedicamentos : Form
    {
        public int Usuario { get; set; }
        public string Accion { get; set; }
        public int Id { get; set; }
        public MantenimientoMedicamentos()
        {
            InitializeComponent();
        }

        private void MantenimientoMedicamentos_Load(object sender, EventArgs e)
        {
            try
            {
                NTipo_Medicamentos NegociosTipoProducto = new NTipo_Medicamentos();
                this.cbo_tipo_medicamento.DisplayMember = "Text";
                this.cbo_tipo_medicamento.ValueMember = "Value";
                var TipoProductoDataSource = NegociosTipoProducto.Mostrar().Select(x => new
                {
                    Text = x.Nombre,
                    Value = x.ID_Tipo_Medicamento
                }
                );
                this.cbo_tipo_medicamento.DataSource = TipoProductoDataSource.ToArray();
                if (Accion == "A")
                {
                    this.lbl_id.Visible = false;
                    this.txt_id.Visible = false;
                }
                if (Accion == "M" || Accion == "C")
                {
                    llenar();
                    if (Accion == "C")
                    {
                        this.grp_Medicamentos.Enabled = false;
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
            NMedicamentos Negocios = new NMedicamentos();
            EMedicamentos Obj = new EMedicamentos();
            Obj = Negocios.Mostrar().Where(x => x.ID_Medicamento == Id).FirstOrDefault();
            this.txt_id.Text = Obj.ID_Medicamento.ToString();
            this.txt_nombre.Text = Obj.Nombre;
            this.txt_concentracion.Text = Obj.Concentracion.ToString();
            this.cbo_tipo_medicamento.SelectedValue = Obj.ID_Tipo_Medicamento;
            this.txt_presentacion.Text = Obj.Presentacion.ToString();
            this.txt_cantidad.Text = Obj.Cantidad.ToString();
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
                if (this.txt_concentracion.Text == "")
                {
                    errorProvider1.SetError(this.txt_concentracion, "Debe ingresar la concentracion");
                    ok = true;
                }
                if (this.txt_cantidad.Text == "")
                {
                    errorProvider1.SetError(this.txt_cantidad, "Debe ingresar la cantidad");
                    ok = true;
                }
                if (this.txt_presentacion.Text == "")
                {
                    errorProvider1.SetError(this.txt_presentacion, "Debe ingresar la concentracion");
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
                errorProvider1.SetError(txt_id, "");
                errorProvider1.SetError(txt_nombre, "");
                errorProvider1.SetError(txt_presentacion, "");
                errorProvider1.SetError(txt_cantidad, "");
                errorProvider1.SetError(txt_concentracion, "");
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
                        NMedicamentos Negocios = new NMedicamentos();
                        EMedicamentos Obj = new EMedicamentos();
                        Obj.Nombre = this.txt_nombre.Text;
                        Obj.Presentacion = this.txt_presentacion.Text;
                        Obj.ID_Tipo_Medicamento = int.Parse(this.cbo_tipo_medicamento.SelectedValue.ToString());
                        Obj.Cantidad = int.Parse(this.txt_cantidad.Text);
                        Obj.Concentracion = int.Parse(this.txt_concentracion.Text);
                        Int32 FilasAfectadas = 0;
                        #region Agregar
                        if (Accion == "A")
                        {
                            FilasAfectadas = Negocios.Agregar(Obj, Usuario);

                            if (FilasAfectadas > 0)
                            {
                                MessageBox.Show("Producto Agregado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                if (FilasAfectadas == -1)
                                {
                                    MessageBox.Show("El Producto se ha agregado exitosamente pero no se a podido registrar la transaccion!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Error al agregar el Producto!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        #endregion

                        #region Modificar
                        if (Accion == "M")
                        {
                            Obj.ID_Medicamento = int.Parse(this.txt_id.Text);
                            FilasAfectadas = Negocios.Modificar(Obj, Usuario);
                            if (FilasAfectadas > 0)
                            {
                                MessageBox.Show("Producto modificado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                if (FilasAfectadas == -1)
                                {
                                    MessageBox.Show("EL Producto se ha modificado exitosamente pero no se a podido registrar la transaccion!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Error al modificar la Producto!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
