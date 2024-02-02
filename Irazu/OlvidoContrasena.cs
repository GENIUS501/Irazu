using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lienzos
{
    public partial class OlvidoContrasena : Form
    {
        public OlvidoContrasena()
        {
            InitializeComponent();
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            bool ok = false;
            if (this.txt_correo.Text == "")
            {
                errorProvider1.SetError(this.txt_correo, "Debe ingresar el correo");
                ok = true;
            }
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(this.txt_correo.Text, expresion))
            {
                if (Regex.Replace(this.txt_correo.Text, expresion, String.Empty).Length == 0)
                {

                }
                else
                {
                    errorProvider1.SetError(this.txt_correo, "Formato de correo invalido");
                    ok = true;
                }
            }
            else
            {
                errorProvider1.SetError(this.txt_correo, "Formato de correo invalido");
                ok = true;
            }
            if (!ok)
            {

            }
        }
    }
}
