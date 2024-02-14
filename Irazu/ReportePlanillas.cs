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
        public ReportePlanillas()
        {
            InitializeComponent();
        }

        private void ReportePlanillas_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    NPersonal Negocios = new NPersonal();
            //    var datasource = Negocios.Mostrar();
            //    ReportDataSource Rds = new ReportDataSource("DataSet1", datasource);
            //    this.reportViewer1.LocalReport.DataSources.Clear();
            //    this.reportViewer1.LocalReport.DataSources.Add(Rds);
            //    ReportParameter[] parameters = new ReportParameter[2];
            //    parameters[0] = new ReportParameter("Usuario", Usuario);
            //    parameters[1] = new ReportParameter("Fecha", DateTime.Now.ToString());
            //    reportViewer1.LocalReport.SetParameters(parameters);
            //    this.reportViewer1.RefreshReport();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            try
            {
                NBitacora_Sesiones Negocios = new NBitacora_Sesiones();
                NUsuarios NegociosUsuarios = new NUsuarios();
                var datasource = Negocios.Mostrar().Select(x => new
                {
                    x.fecha_hora_salida,
                    x.fecha_hora_ingreso,
                    x.codigo_ingreso_salida,
                    Usuario = NegociosUsuarios.Mostrar().Where(c => c.ID_Usuario == x.Id_Usuario).FirstOrDefault().Nombre_Usuario
                }).ToList();
                ReportDataSource Rds = new ReportDataSource("DataSet1", datasource);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(Rds);
                ReportParameter[] parameters = new ReportParameter[2];
                parameters[0] = new ReportParameter("Usuario", Usuariologueado);
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
