namespace Lienzos
{
    partial class MantenimientoMedicamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoMedicamentos));
            this.grp_Medicamentos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_tipo_medicamento = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_presentacion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_concentracion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.MaskedTextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grp_Medicamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_Medicamentos
            // 
            this.grp_Medicamentos.Controls.Add(this.label1);
            this.grp_Medicamentos.Controls.Add(this.label2);
            this.grp_Medicamentos.Controls.Add(this.cbo_tipo_medicamento);
            this.grp_Medicamentos.Controls.Add(this.pictureBox1);
            this.grp_Medicamentos.Controls.Add(this.txt_presentacion);
            this.grp_Medicamentos.Controls.Add(this.label10);
            this.grp_Medicamentos.Controls.Add(this.txt_cantidad);
            this.grp_Medicamentos.Controls.Add(this.label4);
            this.grp_Medicamentos.Controls.Add(this.txt_concentracion);
            this.grp_Medicamentos.Controls.Add(this.label3);
            this.grp_Medicamentos.Controls.Add(this.txt_nombre);
            this.grp_Medicamentos.Controls.Add(this.Nombre);
            this.grp_Medicamentos.Controls.Add(this.txt_id);
            this.grp_Medicamentos.Controls.Add(this.lbl_id);
            this.grp_Medicamentos.Location = new System.Drawing.Point(12, 12);
            this.grp_Medicamentos.Name = "grp_Medicamentos";
            this.grp_Medicamentos.Size = new System.Drawing.Size(427, 303);
            this.grp_Medicamentos.TabIndex = 0;
            this.grp_Medicamentos.TabStop = false;
            this.grp_Medicamentos.Text = "Datos del medicamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 94;
            this.label1.Text = "mg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 93;
            this.label2.Text = "Tipos de medicamentos";
            // 
            // cbo_tipo_medicamento
            // 
            this.cbo_tipo_medicamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tipo_medicamento.FormattingEnabled = true;
            this.cbo_tipo_medicamento.Location = new System.Drawing.Point(9, 125);
            this.cbo_tipo_medicamento.Name = "cbo_tipo_medicamento";
            this.cbo_tipo_medicamento.Size = new System.Drawing.Size(223, 21);
            this.cbo_tipo_medicamento.TabIndex = 92;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lienzos.Properties.Resources.Imagen_de_WhatsApp_2023_11_22_a_las_19_30_10_be162142;
            this.pictureBox1.Location = new System.Drawing.Point(278, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // txt_presentacion
            // 
            this.txt_presentacion.Location = new System.Drawing.Point(9, 175);
            this.txt_presentacion.Multiline = true;
            this.txt_presentacion.Name = "txt_presentacion";
            this.txt_presentacion.Size = new System.Drawing.Size(409, 122);
            this.txt_presentacion.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Presentacion";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(152, 84);
            this.txt_cantidad.Mask = "000000000000";
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(104, 20);
            this.txt_cantidad.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Cantidad";
            // 
            // txt_concentracion
            // 
            this.txt_concentracion.Location = new System.Drawing.Point(9, 84);
            this.txt_concentracion.Name = "txt_concentracion";
            this.txt_concentracion.Size = new System.Drawing.Size(104, 20);
            this.txt_concentracion.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Concentracion";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(152, 45);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(104, 20);
            this.txt_nombre.TabIndex = 25;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(149, 29);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 27;
            this.Nombre.Text = "Nombre";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(9, 45);
            this.txt_id.Mask = "000000000000";
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 24;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(6, 29);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(121, 13);
            this.lbl_id.TabIndex = 26;
            this.lbl_id.Text = "Codigo de medicamento";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(227, 321);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 23);
            this.btnCancelar.TabIndex = 20;
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
            this.btnAceptar.Location = new System.Drawing.Point(111, 321);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(79, 23);
            this.btnAceptar.TabIndex = 19;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MantenimientoMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 356);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grp_Medicamentos);
            this.Name = "MantenimientoMedicamentos";
            this.Text = "MantenimientoMedicamentos";
            this.Load += new System.EventHandler(this.MantenimientoMedicamentos_Load);
            this.grp_Medicamentos.ResumeLayout(false);
            this.grp_Medicamentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Medicamentos;
        private System.Windows.Forms.MaskedTextBox txt_cantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_concentracion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.MaskedTextBox txt_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_presentacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_tipo_medicamento;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
    }
}