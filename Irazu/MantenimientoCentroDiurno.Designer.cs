namespace Lienzos
{
    partial class MantenimientoCentroDiurno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoCentroDiurno));
            this.grpdatos = new System.Windows.Forms.GroupBox();
            this.txt_apellido2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_apellido1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_Genero = new System.Windows.Forms.ComboBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.txt_cedula = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GrpOtros = new System.Windows.Forms.GroupBox();
            this.TxtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.TxtNumeroExpediente = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtMedicamentos = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtPadecimientos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtLugar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtFamiliar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpdatos.SuspendLayout();
            this.GrpOtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpdatos
            // 
            this.grpdatos.Controls.Add(this.txt_apellido2);
            this.grpdatos.Controls.Add(this.label4);
            this.grpdatos.Controls.Add(this.txt_apellido1);
            this.grpdatos.Controls.Add(this.label3);
            this.grpdatos.Controls.Add(this.cbo_Genero);
            this.grpdatos.Controls.Add(this.txt_nombre);
            this.grpdatos.Controls.Add(this.Nombre);
            this.grpdatos.Controls.Add(this.txt_cedula);
            this.grpdatos.Controls.Add(this.label2);
            this.grpdatos.Controls.Add(this.label1);
            this.grpdatos.Location = new System.Drawing.Point(12, 12);
            this.grpdatos.Name = "grpdatos";
            this.grpdatos.Size = new System.Drawing.Size(257, 187);
            this.grpdatos.TabIndex = 15;
            this.grpdatos.TabStop = false;
            this.grpdatos.Text = "Datos del paciente";
            // 
            // txt_apellido2
            // 
            this.txt_apellido2.Location = new System.Drawing.Point(132, 81);
            this.txt_apellido2.Name = "txt_apellido2";
            this.txt_apellido2.Size = new System.Drawing.Size(104, 20);
            this.txt_apellido2.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Segundo Apellido";
            // 
            // txt_apellido1
            // 
            this.txt_apellido1.Location = new System.Drawing.Point(9, 81);
            this.txt_apellido1.Name = "txt_apellido1";
            this.txt_apellido1.Size = new System.Drawing.Size(104, 20);
            this.txt_apellido1.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Primer Apellido";
            // 
            // cbo_Genero
            // 
            this.cbo_Genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Genero.FormattingEnabled = true;
            this.cbo_Genero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbo_Genero.Location = new System.Drawing.Point(9, 139);
            this.cbo_Genero.Name = "cbo_Genero";
            this.cbo_Genero.Size = new System.Drawing.Size(227, 21);
            this.cbo_Genero.TabIndex = 19;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(132, 42);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(104, 20);
            this.txt_nombre.TabIndex = 1;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(129, 26);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 7;
            this.Nombre.Text = "Nombre";
            // 
            // txt_cedula
            // 
            this.txt_cedula.Location = new System.Drawing.Point(9, 42);
            this.txt_cedula.Mask = "000000000000";
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(100, 20);
            this.txt_cedula.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Genero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cédula";
            // 
            // GrpOtros
            // 
            this.GrpOtros.Controls.Add(this.TxtTelefono);
            this.GrpOtros.Controls.Add(this.TxtNumeroExpediente);
            this.GrpOtros.Controls.Add(this.label11);
            this.GrpOtros.Controls.Add(this.TxtMedicamentos);
            this.GrpOtros.Controls.Add(this.label10);
            this.GrpOtros.Controls.Add(this.TxtPadecimientos);
            this.GrpOtros.Controls.Add(this.label9);
            this.GrpOtros.Controls.Add(this.TxtLugar);
            this.GrpOtros.Controls.Add(this.label8);
            this.GrpOtros.Controls.Add(this.label7);
            this.GrpOtros.Controls.Add(this.TxtFamiliar);
            this.GrpOtros.Controls.Add(this.label6);
            this.GrpOtros.Location = new System.Drawing.Point(275, 12);
            this.GrpOtros.Name = "GrpOtros";
            this.GrpOtros.Size = new System.Drawing.Size(458, 388);
            this.GrpOtros.TabIndex = 16;
            this.GrpOtros.TabStop = false;
            this.GrpOtros.Text = "Otros datos";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(314, 42);
            this.TxtTelefono.Mask = "00000000";
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(100, 20);
            this.TxtTelefono.TabIndex = 34;
            // 
            // TxtNumeroExpediente
            // 
            this.TxtNumeroExpediente.Location = new System.Drawing.Point(9, 42);
            this.TxtNumeroExpediente.Name = "TxtNumeroExpediente";
            this.TxtNumeroExpediente.Size = new System.Drawing.Size(104, 20);
            this.TxtNumeroExpediente.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Numero de expediente";
            // 
            // TxtMedicamentos
            // 
            this.TxtMedicamentos.Location = new System.Drawing.Point(9, 247);
            this.TxtMedicamentos.Multiline = true;
            this.TxtMedicamentos.Name = "TxtMedicamentos";
            this.TxtMedicamentos.Size = new System.Drawing.Size(409, 122);
            this.TxtMedicamentos.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Medicamentos";
            // 
            // TxtPadecimientos
            // 
            this.TxtPadecimientos.Location = new System.Drawing.Point(9, 103);
            this.TxtPadecimientos.Multiline = true;
            this.TxtPadecimientos.Name = "TxtPadecimientos";
            this.TxtPadecimientos.Size = new System.Drawing.Size(187, 110);
            this.TxtPadecimientos.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Descripcion de posibles padecimientos";
            // 
            // TxtLugar
            // 
            this.TxtLugar.Location = new System.Drawing.Point(216, 103);
            this.TxtLugar.Multiline = true;
            this.TxtLugar.Name = "TxtLugar";
            this.TxtLugar.Size = new System.Drawing.Size(202, 110);
            this.TxtLugar.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(213, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Lugar de vivienda";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Telefono";
            // 
            // TxtFamiliar
            // 
            this.TxtFamiliar.Location = new System.Drawing.Point(129, 42);
            this.TxtFamiliar.Name = "TxtFamiliar";
            this.TxtFamiliar.Size = new System.Drawing.Size(163, 20);
            this.TxtFamiliar.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Familiar directo";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(394, 407);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 23);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.Location = new System.Drawing.Point(278, 407);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(79, 23);
            this.btnAceptar.TabIndex = 17;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lienzos.Properties.Resources.Imagen_de_WhatsApp_2023_11_22_a_las_19_30_10_be162142;
            this.pictureBox1.Location = new System.Drawing.Point(12, 220);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 89;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MantenimientoCentroDiurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(742, 442);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.GrpOtros);
            this.Controls.Add(this.grpdatos);
            this.MaximizeBox = false;
            this.Name = "MantenimientoCentroDiurno";
            this.Text = "Mantenimiento de Usuario CentroDiurno";
            this.Load += new System.EventHandler(this.MantenimientoCentroDiurno_Load);
            this.grpdatos.ResumeLayout(false);
            this.grpdatos.PerformLayout();
            this.GrpOtros.ResumeLayout(false);
            this.GrpOtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpdatos;
        private System.Windows.Forms.TextBox txt_apellido2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_apellido1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_Genero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.MaskedTextBox txt_cedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GrpOtros;
        private System.Windows.Forms.TextBox TxtNumeroExpediente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtMedicamentos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtPadecimientos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtLugar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtFamiliar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox TxtTelefono;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}