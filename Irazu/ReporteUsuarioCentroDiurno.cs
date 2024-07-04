using Entidades;
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
    public partial class ReporteUsuarioCentroDiurno : Form
    {
        public string Usuario { get; set; }
        public ReporteUsuarioCentroDiurno()
        {
            InitializeComponent();
        }

        private void ReporteUsuarioCentroDiurno_Load(object sender, EventArgs e)
        {
            try
            {
                NUsuarioCentroDiurno Negocios = new NUsuarioCentroDiurno();
                var datasource = Negocios.Mostrar().Select(x => new
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
                    Fecha_Hora_Ingreso = x.Fecha_Hora_Ingreso,
                    Fecha_Hora_Salida = x.Fecha_Hora_Salida,
                    Total_Dias = (x.Fecha_Hora_Salida != null) ? (x.Fecha_Hora_Salida - x.Fecha_Hora_Ingreso).Value.Days : (DateTime.Now - x.Fecha_Hora_Ingreso).Days
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

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_expediente.Text != "")
                {
                    NUsuarioCentroDiurno Negocios = new NUsuarioCentroDiurno();
                    var datasource = Negocios.Mostrar().Where(x => x.Cedula.Contains(this.txt_expediente.Text)).Select(x => new
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
                        Fecha_Hora_Ingreso = x.Fecha_Hora_Ingreso,
                        Fecha_Hora_Salida = x.Fecha_Hora_Salida,
                        Total_Dias = (x.Fecha_Hora_Salida != null) ? (x.Fecha_Hora_Salida - x.Fecha_Hora_Ingreso).Value.Days : (DateTime.Now - x.Fecha_Hora_Ingreso).Days
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
                    NUsuarioCentroDiurno Negocios = new NUsuarioCentroDiurno();
                    var datasource = Negocios.Mostrar().Where(x => x.Cedula.Contains(this.txt_cedula.Text)).Select(x => new
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
                        Fecha_Hora_Ingreso = x.Fecha_Hora_Ingreso,
                        Fecha_Hora_Salida = x.Fecha_Hora_Salida,
                        Total_Dias = (x.Fecha_Hora_Salida != null) ? (x.Fecha_Hora_Salida - x.Fecha_Hora_Ingreso).Value.Days : (DateTime.Now - x.Fecha_Hora_Ingreso).Days
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
                    NUsuarioCentroDiurno Negocios = new NUsuarioCentroDiurno();
                    var datasource = Negocios.Mostrar().Where(x => x.Nombre.Contains(this.txt_nombre.Text)).Select(x => new 
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
                        Fecha_Hora_Ingreso = x.Fecha_Hora_Ingreso,
                        Fecha_Hora_Salida = x.Fecha_Hora_Salida,
                        Total_Dias= (x.Fecha_Hora_Salida!=null)?(x.Fecha_Hora_Salida-x.Fecha_Hora_Ingreso).Value.Days: (DateTime.Now - x.Fecha_Hora_Ingreso).Days
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
