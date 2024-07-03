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
    public partial class ReportePersonal : Form
    {
        public string Usuario { get; set; }
        public ReportePersonal()
        {
            InitializeComponent();
        }

        private void ReportePersonal_Load(object sender, EventArgs e)
        {
            try
            {
                NPersonal Negocios = new NPersonal();
                var datasource = Negocios.Mostrar().Select(x => new
                {
                    Cedula = x.Cedula,
                    Nombre = x.Nombre,
                    Primer_Apellido = x.Primer_Apellido,
                    Segundo_Apellido = x.Segundo_Apellido,
                    Genero = (x.Genero == 1) ? "Masculino" : "Femenino",
                    ID = x.ID,
                    Estado = x.Estado,
                    Telefono = x.Telefono,
                    Direccion = x.Direccion,
                    Id_Puesto = x.Id_Puesto,
                    Fecha_Hora_Ingreso = x.Fecha_Hora_Ingreso,
                    Fecha_Hora_Salida = x.Fecha_Hora_Salida
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_cedula.Text != "")
                {
                    NPersonal Negocios = new NPersonal();
                    var datasource = Negocios.Mostrar().Select(x => new
                    {
                        Cedula = x.Cedula,
                        Nombre = x.Nombre,
                        Primer_Apellido = x.Primer_Apellido,
                        Segundo_Apellido = x.Segundo_Apellido,
                        Genero = (x.Genero == 1) ? "Masculino" : "Femenino",
                        ID = x.ID,
                        Estado = x.Estado,
                        Telefono = x.Telefono,
                        Direccion = x.Direccion,
                        Id_Puesto = x.Id_Puesto,
                        Fecha_Hora_Ingreso = x.Fecha_Hora_Ingreso,
                        Fecha_Hora_Salida = x.Fecha_Hora_Salida
                    }).Where(x => x.Cedula.Contains(this.txt_cedula.Text)).ToList();
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_nombre.Text != "")
                {
                    NPersonal Negocios = new NPersonal();
                    var datasource = Negocios.Mostrar().Select(x => new
                    {
                        Cedula = x.Cedula,
                        Nombre = x.Nombre,
                        Primer_Apellido = x.Primer_Apellido,
                        Segundo_Apellido = x.Segundo_Apellido,
                        Genero = (x.Genero == 1) ? "Masculino" : "Femenino",
                        ID = x.ID,
                        Estado = x.Estado,
                        Telefono = x.Telefono,
                        Direccion = x.Direccion,
                        Id_Puesto = x.Id_Puesto,
                        Fecha_Hora_Ingreso = x.Fecha_Hora_Ingreso,
                        Fecha_Hora_Salida = x.Fecha_Hora_Salida
                    }).Where(x => x.Nombre.Contains(this.txt_nombre.Text)).ToList();
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
    }
}
