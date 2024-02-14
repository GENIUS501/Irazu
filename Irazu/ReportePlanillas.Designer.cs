
namespace Lienzos
{
    partial class ReportePlanillas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportePlanillas));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_nombre = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cedula = new System.Windows.Forms.Button();
            this.txt_cedula = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbo_puestos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_puestos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Lienzos.ReportePlanillas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 171);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 267);
            this.reportViewer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_puestos);
            this.groupBox1.Controls.Add(this.cbo_puestos);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_nombre);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_cedula);
            this.groupBox1.Controls.Add(this.txt_cedula);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 139);
            this.groupBox1.TabIndex = 111;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de busqueda";
            // 
            // btn_nombre
            // 
            this.btn_nombre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_nombre.BackgroundImage")));
            this.btn_nombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nombre.Location = new System.Drawing.Point(115, 105);
            this.btn_nombre.Name = "btn_nombre";
            this.btn_nombre.Size = new System.Drawing.Size(25, 20);
            this.btn_nombre.TabIndex = 41;
            this.btn_nombre.UseVisualStyleBackColor = true;
            this.btn_nombre.Click += new System.EventHandler(this.btn_nombre_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(9, 105);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Nombre Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Numero de cedula";
            // 
            // btn_cedula
            // 
            this.btn_cedula.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cedula.BackgroundImage")));
            this.btn_cedula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cedula.Location = new System.Drawing.Point(115, 48);
            this.btn_cedula.Name = "btn_cedula";
            this.btn_cedula.Size = new System.Drawing.Size(25, 20);
            this.btn_cedula.TabIndex = 37;
            this.btn_cedula.UseVisualStyleBackColor = true;
            this.btn_cedula.Click += new System.EventHandler(this.btn_cedula_Click);
            // 
            // txt_cedula
            // 
            this.txt_cedula.Location = new System.Drawing.Point(9, 48);
            this.txt_cedula.Mask = "0000000000";
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(100, 20);
            this.txt_cedula.TabIndex = 36;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lienzos.Properties.Resources.Imagen_de_WhatsApp_2023_11_22_a_las_19_30_10_be162142;
            this.pictureBox1.Location = new System.Drawing.Point(623, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 113;
            this.pictureBox1.TabStop = false;
            // 
            // cbo_puestos
            // 
            this.cbo_puestos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_puestos.FormattingEnabled = true;
            this.cbo_puestos.Location = new System.Drawing.Point(166, 49);
            this.cbo_puestos.Name = "cbo_puestos";
            this.cbo_puestos.Size = new System.Drawing.Size(227, 21);
            this.cbo_puestos.TabIndex = 94;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 93;
            this.label5.Text = "Puesto";
            // 
            // btn_puestos
            // 
            this.btn_puestos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_puestos.BackgroundImage")));
            this.btn_puestos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_puestos.Location = new System.Drawing.Point(399, 49);
            this.btn_puestos.Name = "btn_puestos";
            this.btn_puestos.Size = new System.Drawing.Size(25, 20);
            this.btn_puestos.TabIndex = 95;
            this.btn_puestos.UseVisualStyleBackColor = true;
            this.btn_puestos.Click += new System.EventHandler(this.btn_puestos_Click);
            // 
            // ReportePlanillas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportePlanillas";
            this.Text = "ReportePlanillas";
            this.Load += new System.EventHandler(this.ReportePlanillas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cedula;
        private System.Windows.Forms.MaskedTextBox txt_cedula;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbo_puestos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_puestos;
    }
}