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

            this.reportViewer1.RefreshReport();
        }
    }
}
