using Microsoft.Reporting.WinForms;
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
    public partial class ReportePlanillas : Form
    {
        public string Usuario { get; set; }
        public ReportePlanillas()
        {
            InitializeComponent();
        }

        private void ReportePlanillas_Load(object sender, EventArgs e)
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
                NPersonal Negocios = new NPersonal();
                var datasource = Negocios.Mostrar().Select(x => new
                {
                    x.Cedula,
                    x.Nombre,
                    Apellido1 = x.Primer_Apellido,
                    Apellido2 = x.Segundo_Apellido,
                    Puesto = NegociosPuestos.Mostrar().Where(c => c.Id_Puesto == x.Id_Puesto).FirstOrDefault().Nombre,
                    Salario = NegociosPuestos.Mostrar().Where(c => c.Id_Puesto == x.Id_Puesto).FirstOrDefault().Salario
                }).ToList();
                ReportDataSource Rds = new ReportDataSource("DataSet1", datasource);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(Rds);
                ReportParameter[] parameters = new ReportParameter[2];
                parameters[0] = new ReportParameter("Usuario", Usuario);
                parameters[1] = new ReportParameter("Fecha", DateTime.Now.ToString());
                reportViewer1.LocalReport.SetParameters(parameters);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cedula_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_cedula.Text != "")
                {
                    NPersonal Negocios = new NPersonal();
                    NPuestos NegociosPuestos = new NPuestos();
                    var datasource = Negocios.Mostrar().Select(x => new
                    {
                        x.Cedula,
                        x.Nombre,
                        Apellido1 = x.Primer_Apellido,
                        Apellido2 = x.Segundo_Apellido,
                        Puesto = NegociosPuestos.Mostrar().Where(c => c.Id_Puesto == x.Id_Puesto).FirstOrDefault().Nombre,
                        Salario = NegociosPuestos.Mostrar().Where(c => c.Id_Puesto == x.Id_Puesto).FirstOrDefault().Salario
                    }).Where(z => z.Cedula.Contains(this.txt_cedula.Text)).ToList();
                    ReportDataSource Rds = new ReportDataSource("DataSet1", datasource);
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(Rds);
                    ReportParameter[] parameters = new ReportParameter[2];
                    parameters[0] = new ReportParameter("Usuario", Usuario);
                    parameters[1] = new ReportParameter("Fecha", DateTime.Now.ToString());
                    reportViewer1.LocalReport.SetParameters(parameters);
                    this.reportViewer1.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_nombre_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_nombre.Text != "")
                {
                    NPersonal Negocios = new NPersonal();
                    NPuestos NegociosPuestos = new NPuestos();
                    var datasource = Negocios.Mostrar().Select(x => new
                    {
                        x.Cedula,
                        x.Nombre,
                        Apellido1 = x.Primer_Apellido,
                        Apellido2 = x.Segundo_Apellido,
                        Puesto = NegociosPuestos.Mostrar().Where(c => c.Id_Puesto == x.Id_Puesto).FirstOrDefault().Nombre,
                        Salario = NegociosPuestos.Mostrar().Where(c => c.Id_Puesto == x.Id_Puesto).FirstOrDefault().Salario
                    }).Where(z => z.Nombre.Contains(this.txt_nombre.Text)).ToList();
                    ReportDataSource Rds = new ReportDataSource("DataSet1", datasource);
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(Rds);
                    ReportParameter[] parameters = new ReportParameter[2];
                    parameters[0] = new ReportParameter("Usuario", Usuario);
                    parameters[1] = new ReportParameter("Fecha", DateTime.Now.ToString());
                    reportViewer1.LocalReport.SetParameters(parameters);
                    this.reportViewer1.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_puestos_Click(object sender, EventArgs e)
        {
            try
            {
                NPersonal Negocios = new NPersonal();
                NPuestos NegociosPuestos = new NPuestos();
                var datasource = Negocios.Mostrar().Select(x => new
                {
                    x.Cedula,
                    x.Nombre,
                    Apellido1 = x.Primer_Apellido,
                    Apellido2 = x.Segundo_Apellido,
                    Puesto = NegociosPuestos.Mostrar().Where(c => c.Id_Puesto == x.Id_Puesto).FirstOrDefault().Nombre,
                    Salario = NegociosPuestos.Mostrar().Where(c => c.Id_Puesto == x.Id_Puesto).FirstOrDefault().Salario
                }).Where(z => z.Puesto.Contains(NegociosPuestos.Mostrar().Where(c => c.Id_Puesto == int.Parse(this.cbo_puestos.SelectedValue.ToString())).FirstOrDefault().Nombre)).ToList();
                ReportDataSource Rds = new ReportDataSource("DataSet1", datasource);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(Rds);
                ReportParameter[] parameters = new ReportParameter[2];
                parameters[0] = new ReportParameter("Usuario", Usuario);
                parameters[1] = new ReportParameter("Fecha", DateTime.Now.ToString());
                reportViewer1.LocalReport.SetParameters(parameters);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
