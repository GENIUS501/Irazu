using Entidades;
using Irazu;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
                        string fromEmail = smtpUsername;

                        // Dirección de correo electrónico del destinatario
                        string toEmail = Obj.Correo;

                        // Configurar el cliente SMTP
                        using (SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort))
                        {
                            smtpClient.UseDefaultCredentials = false;
                            smtpClient.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
                            smtpClient.EnableSsl = true; // Usar SSL para conexiones seguras

                            // Crear el mensaje de correo electrónico
                            using (MailMessage mailMessage = new MailMessage(fromEmail, toEmail))
                            {
                                mailMessage.Subject = "Recuperacion de contraseña Irazu";
                                string Token = Helper.EncodePassword(string.Concat(Obj.Nombre_Usuario,Obj.Correo, DateTime.Now.ToString()));
                                mailMessage.Body = "Token para recuperar la contraseña: "+Token;

                                // Puedes adjuntar archivos si es necesario
                                // mailMessage.Attachments.Add(new Attachment("ruta_del_archivo"));

                                try
                                {
                                    // Enviar el correo electrónico
                                    smtpClient.Send(mailMessage);
                                    MessageBox.Show("Correo electrónico enviado con éxito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    CambioContrasena frm = new CambioContrasena();
                                    frm.Usuario = Obj.Nombre_Usuario;
                                    frm.Token = Token;
                                    frm.MaximizeBox = false;
                                    frm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                                    frm.Show();
                                    this.Hide();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error al enviar el correo electrónico: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
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
