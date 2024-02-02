using Entidades;
using Irazu;
using Negocios;
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
    public partial class CambioContrasena : Form
    {
        public string Token { get; set; }
        public string Usuario { get; set; }
        public CambioContrasena()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                bool ok = false;
                if (this.txt_clave.Text != this.txt_cclave.Text)
                {
                    errorProvider1.SetError(this.txt_cclave, "Las contraseñas no coinciden.");
                    ok = true;
                }
                if (this.txt_token.Text == "")
                {
                    errorProvider1.SetError(this.txt_token, "Debe indicar el token");
                    ok = true;
                }
                Regex Regexa = new Regex(@"^(?=.*[\d])(?=.*[A-Z])(?=.*[a-z])[\w\d]{8,}$");
                Match Match = Regexa.Match(this.txt_clave.Text);
                if (Match.Success || this.txt_clave.Text == "********")
                {

                }
                else
                {
                    errorProvider1.SetError(this.txt_clave, "La contraseña debe de tener un mínimo de 8 caracteres, con lo siguiente: " +
                    "\n Al menos una mayúscula" +
                    "\n Al menos una minúscula" +
                    "\n Al menos un número" +
                    "\n No debe tener caracteres especiales ni espacios");
                    ok = true;
                }
                if (!ok)
                {
                    errorProvider1.SetError(this.txt_token, "");
                    errorProvider1.SetError(this.txt_clave, "");
                    errorProvider1.SetError(this.txt_cclave, "");
                    if (Token == this.txt_token.Text)
                    {
                        NUsuarios Negocios = new NUsuarios();
                        EUsuario Obj = new EUsuario();
                        Obj = Negocios.Mostrar().Where(x => x.Nombre_Usuario == Usuario).FirstOrDefault();
                        Obj.Contrasena = Helper.EncodePassword(string.Concat(Obj.Nombre_Usuario, this.txt_clave.ToString()));
                        int FilasAfectadas = Negocios.Modificar(Obj);
                        MessageBox.Show("Contraseña recuperada con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
