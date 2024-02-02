using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
            try
            {
                if (this.txt_user.Text == "")
                {
                    errorProvider1.SetError(this.txt_user, "Debe ingresar el nombre de usuario");
                }
                else
                {
                    errorProvider1.SetError(this.txt_user, "");
                    NUsuarios Negocios = new NUsuarios();
                    EUsuario Obj = new EUsuario();
                    Obj = Negocios.Mostrar().Where(x => x.Nombre_Usuario == this.txt_user.Text).FirstOrDefault();
                    if (Obj != null)
                    {
                        string smtpServer = ConfigurationManager.AppSettings["SmtpServer"];
                        int smtpPort = int.Parse(ConfigurationManager.AppSettings["SmtpPort"]);
                        string smtpUsername = ConfigurationManager.AppSettings["SmtpUsername"];
                        string smtpPassword = ConfigurationManager.AppSettings["SmtpPassword"];
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
