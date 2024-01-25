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
            NPersonal Negocios = new NPersonal();
            var datasource = Negocios.Mostrar();
            ReportDataSource Rds = new ReportDataSource("DataSet1", datasource);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(Rds);
            ReportParameter[] parameters = new ReportParameter[2];
            parameters[0] = new ReportParameter("Usuario", Usuario);
            parameters[1] = new ReportParameter("Fecha", DateTime.Now.ToString());
            reportViewer1.LocalReport.SetParameters(parameters);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
