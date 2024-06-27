namespace Irazu
{
    partial class ProcesoDevolucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcesoDevolucion));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_buscar_id = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscar_cedula = new System.Windows.Forms.MaskedTextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.dat_principal = new System.Windows.Forms.DataGridView();
            this.btn_reimprimir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_fecha = new System.Windows.Forms.Button();
            this.txt_fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.txt_fecha_ini = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_principal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_fecha);
            this.groupBox1.Controls.Add(this.txt_fecha_fin);
            this.groupBox1.Controls.Add(this.txt_fecha_ini);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_buscar_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.txt_buscar_cedula);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 121);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Búsqueda";
            // 
            // btn_buscar_id
            // 
            this.btn_buscar_id.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar_id.BackgroundImage")));
            this.btn_buscar_id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_id.Location = new System.Drawing.Point(303, 48);
            this.btn_buscar_id.Name = "btn_buscar_id";
            this.btn_buscar_id.Size = new System.Drawing.Size(25, 20);
            this.btn_buscar_id.TabIndex = 3;
            this.btn_buscar_id.UseVisualStyleBackColor = true;
            this.btn_buscar_id.Click += new System.EventHandler(this.btn_buscar_id_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Cedula del cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(194, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Numero de entrega";
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar.BackgroundImage")));
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.Location = new System.Drawing.Point(112, 50);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(25, 20);
            this.btn_buscar.TabIndex = 1;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_buscar_cedula
            // 
            this.txt_buscar_cedula.Location = new System.Drawing.Point(6, 48);
            this.txt_buscar_cedula.Mask = "000000000000";
            this.txt_buscar_cedula.Name = "txt_buscar_cedula";
            this.txt_buscar_cedula.Size = new System.Drawing.Size(100, 22);
            this.txt_buscar_cedula.TabIndex = 0;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(197, 47);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 22);
            this.txt_id.TabIndex = 2;
            // 
            // dat_principal
            // 
            this.dat_principal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dat_principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_principal.Location = new System.Drawing.Point(10, 181);
            this.dat_principal.Name = "dat_principal";
            this.dat_principal.RowHeadersWidth = 51;
            this.dat_principal.Size = new System.Drawing.Size(739, 185);
            this.dat_principal.TabIndex = 77;
            this.dat_principal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dat_principal_CellClick);
            // 
            // btn_reimprimir
            // 
            this.btn_reimprimir.BackColor = System.Drawing.Color.Beige;
            this.btn_reimprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_reimprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reimprimir.Image = ((System.Drawing.Image)(resources.GetObject("btn_reimprimir.Image")));
            this.btn_reimprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_reimprimir.Location = new System.Drawing.Point(12, 139);
            this.btn_reimprimir.Name = "btn_reimprimir";
            this.btn_reimprimir.Size = new System.Drawing.Size(113, 26);
            this.btn_reimprimir.TabIndex = 82;
            this.btn_reimprimir.Text = "Reimprimir";
            this.btn_reimprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reimprimir.UseVisualStyleBackColor = false;
            this.btn_reimprimir.Click += new System.EventHandler(this.btn_reimprimir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = global::Lienzos.Properties.Resources.Img_p1;
            this.pictureBox1.Location = new System.Drawing.Point(469, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // btn_fecha
            // 
            this.btn_fecha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_fecha.BackgroundImage")));
            this.btn_fecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_fecha.Location = new System.Drawing.Point(324, 89);
            this.btn_fecha.Name = "btn_fecha";
            this.btn_fecha.Size = new System.Drawing.Size(25, 20);
            this.btn_fecha.TabIndex = 61;
            this.btn_fecha.UseVisualStyleBackColor = true;
            // 
            // txt_fecha_fin
            // 
            this.txt_fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_fecha_fin.Location = new System.Drawing.Point(197, 89);
            this.txt_fecha_fin.Name = "txt_fecha_fin";
            this.txt_fecha_fin.Size = new System.Drawing.Size(121, 22);
            this.txt_fecha_fin.TabIndex = 58;
            // 
            // txt_fecha_ini
            // 
            this.txt_fecha_ini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_fecha_ini.Location = new System.Drawing.Point(6, 90);
            this.txt_fecha_ini.Name = "txt_fecha_ini";
            this.txt_fecha_ini.Size = new System.Drawing.Size(100, 22);
            this.txt_fecha_ini.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 60;
            this.label2.Text = "Fecha Final";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 59;
            this.label4.Text = "Fecha inicial";
            // 
            // ProcesoDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(761, 392);
            this.Controls.Add(this.btn_reimprimir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dat_principal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProcesoDevolucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proceso de reimpresiones";
            this.Load += new System.EventHandler(this.ProcesoDevolucion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_principal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_buscar_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.MaskedTextBox txt_buscar_cedula;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.DataGridView dat_principal;
        private System.Windows.Forms.Button btn_reimprimir;
        private System.Windows.Forms.Button btn_fecha;
        private System.Windows.Forms.DateTimePicker txt_fecha_fin;
        private System.Windows.Forms.DateTimePicker txt_fecha_ini;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}