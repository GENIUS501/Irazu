namespace Irazu
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reingresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.Personal = new System.Windows.Forms.ToolStripMenuItem();
            this.Medicamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.Tipo_Medicamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.CentroDiurno = new System.Windows.Forms.ToolStripMenuItem();
            this.Puestos = new System.Windows.Forms.ToolStripMenuItem();
            this.Reportes = new System.Windows.Forms.ToolStripMenuItem();
            this.Reporte_Medicamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.Reporte_Personal = new System.Windows.Forms.ToolStripMenuItem();
            this.Reporte_centro_diurno = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportePlanillas = new System.Windows.Forms.ToolStripMenuItem();
            this.Seguridad = new System.Windows.Forms.ToolStripMenuItem();
            this.Usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.Roles = new System.Windows.Forms.ToolStripMenuItem();
            this.Bitacora_Ingresos = new System.Windows.Forms.ToolStripMenuItem();
            this.Bitacora_Movimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Txt_Usuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.Mantenimientos,
            this.Reportes,
            this.Seguridad,
            this.Salir,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reingresarToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // reingresarToolStripMenuItem
            // 
            this.reingresarToolStripMenuItem.Name = "reingresarToolStripMenuItem";
            this.reingresarToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.reingresarToolStripMenuItem.Text = "Reingresar";
            this.reingresarToolStripMenuItem.Click += new System.EventHandler(this.reingresarToolStripMenuItem_Click);
            // 
            // Mantenimientos
            // 
            this.Mantenimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Personal,
            this.Medicamentos,
            this.Tipo_Medicamentos,
            this.CentroDiurno,
            this.Puestos});
            this.Mantenimientos.Name = "Mantenimientos";
            this.Mantenimientos.Size = new System.Drawing.Size(106, 20);
            this.Mantenimientos.Text = "Mantenimientos";
            // 
            // Personal
            // 
            this.Personal.Name = "Personal";
            this.Personal.Size = new System.Drawing.Size(200, 22);
            this.Personal.Text = "Personal";
            this.Personal.Click += new System.EventHandler(this.Personal_Click);
            // 
            // Medicamentos
            // 
            this.Medicamentos.Name = "Medicamentos";
            this.Medicamentos.Size = new System.Drawing.Size(200, 22);
            this.Medicamentos.Text = "Medicamentos";
            this.Medicamentos.Click += new System.EventHandler(this.Medicamentos_Click);
            // 
            // Tipo_Medicamentos
            // 
            this.Tipo_Medicamentos.Name = "Tipo_Medicamentos";
            this.Tipo_Medicamentos.Size = new System.Drawing.Size(200, 22);
            this.Tipo_Medicamentos.Text = "Tipos de medicamentos";
            this.Tipo_Medicamentos.Click += new System.EventHandler(this.Tipo_Medicamentos_Click);
            // 
            // CentroDiurno
            // 
            this.CentroDiurno.Name = "CentroDiurno";
            this.CentroDiurno.Size = new System.Drawing.Size(200, 22);
            this.CentroDiurno.Text = "Clientes";
            this.CentroDiurno.Click += new System.EventHandler(this.CentroDiurno_Click);
            // 
            // Puestos
            // 
            this.Puestos.Name = "Puestos";
            this.Puestos.Size = new System.Drawing.Size(200, 22);
            this.Puestos.Text = "Puestos";
            this.Puestos.Click += new System.EventHandler(this.Puestos_Click);
            // 
            // Reportes
            // 
            this.Reportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Reporte_Medicamentos,
            this.Reporte_Personal,
            this.Reporte_centro_diurno,
            this.ReportePlanillas});
            this.Reportes.Name = "Reportes";
            this.Reportes.Size = new System.Drawing.Size(65, 20);
            this.Reportes.Text = "Reportes";
            // 
            // Reporte_Medicamentos
            // 
            this.Reporte_Medicamentos.Name = "Reporte_Medicamentos";
            this.Reporte_Medicamentos.Size = new System.Drawing.Size(213, 22);
            this.Reporte_Medicamentos.Text = "Reporte de Medicamentos";
            this.Reporte_Medicamentos.Click += new System.EventHandler(this.Reporte_Medicamentos_Click);
            // 
            // Reporte_Personal
            // 
            this.Reporte_Personal.Name = "Reporte_Personal";
            this.Reporte_Personal.Size = new System.Drawing.Size(213, 22);
            this.Reporte_Personal.Text = "Reporte de Personal";
            this.Reporte_Personal.Click += new System.EventHandler(this.Reporte_Personal_Click);
            // 
            // Reporte_centro_diurno
            // 
            this.Reporte_centro_diurno.Name = "Reporte_centro_diurno";
            this.Reporte_centro_diurno.Size = new System.Drawing.Size(213, 22);
            this.Reporte_centro_diurno.Text = "Reporte de clientes";
            this.Reporte_centro_diurno.Click += new System.EventHandler(this.Reporte_centro_diurno_Click);
            // 
            // ReportePlanillas
            // 
            this.ReportePlanillas.Name = "ReportePlanillas";
            this.ReportePlanillas.Size = new System.Drawing.Size(213, 22);
            this.ReportePlanillas.Text = "Reporte de Planillas";
            this.ReportePlanillas.Click += new System.EventHandler(this.ReportePlanillas_Click);
            // 
            // Seguridad
            // 
            this.Seguridad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Usuarios,
            this.Roles,
            this.Bitacora_Ingresos,
            this.Bitacora_Movimientos});
            this.Seguridad.Name = "Seguridad";
            this.Seguridad.Size = new System.Drawing.Size(72, 20);
            this.Seguridad.Text = "Seguridad";
            // 
            // Usuarios
            // 
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(227, 22);
            this.Usuarios.Text = "Usuarios";
            this.Usuarios.Click += new System.EventHandler(this.Usuarios_Click);
            // 
            // Roles
            // 
            this.Roles.Name = "Roles";
            this.Roles.Size = new System.Drawing.Size(227, 22);
            this.Roles.Text = "Roles";
            this.Roles.Click += new System.EventHandler(this.Roles_Click);
            // 
            // Bitacora_Ingresos
            // 
            this.Bitacora_Ingresos.Name = "Bitacora_Ingresos";
            this.Bitacora_Ingresos.Size = new System.Drawing.Size(227, 22);
            this.Bitacora_Ingresos.Text = "Bitacora de ingresos y salidas";
            this.Bitacora_Ingresos.Click += new System.EventHandler(this.Bitacora_Ingresos_Click);
            // 
            // Bitacora_Movimientos
            // 
            this.Bitacora_Movimientos.Name = "Bitacora_Movimientos";
            this.Bitacora_Movimientos.Size = new System.Drawing.Size(227, 22);
            this.Bitacora_Movimientos.Text = "Bitacora de movimientos";
            this.Bitacora_Movimientos.Click += new System.EventHandler(this.Bitacora_Movimientos_Click);
            // 
            // Salir
            // 
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(41, 20);
            this.Salir.Text = "Salir";
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Txt_Usuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(0, 17);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lienzos.Properties.Resources.Imagen_de_WhatsApp_2023_11_22_a_las_19_30_37_f8edc27e;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Txt_Usuario;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Mantenimientos;
        private System.Windows.Forms.ToolStripMenuItem Personal;
        private System.Windows.Forms.ToolStripMenuItem Medicamentos;
        private System.Windows.Forms.ToolStripMenuItem Tipo_Medicamentos;
        private System.Windows.Forms.ToolStripMenuItem Reportes;
        private System.Windows.Forms.ToolStripMenuItem Seguridad;
        private System.Windows.Forms.ToolStripMenuItem Salir;
        private System.Windows.Forms.ToolStripMenuItem Reporte_Medicamentos;
        private System.Windows.Forms.ToolStripMenuItem Reporte_Personal;
        private System.Windows.Forms.ToolStripMenuItem Reporte_centro_diurno;
        private System.Windows.Forms.ToolStripMenuItem Usuarios;
        private System.Windows.Forms.ToolStripMenuItem Roles;
        private System.Windows.Forms.ToolStripMenuItem Bitacora_Ingresos;
        private System.Windows.Forms.ToolStripMenuItem Bitacora_Movimientos;
        private System.Windows.Forms.ToolStripMenuItem reingresarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CentroDiurno;
        private System.Windows.Forms.ToolStripMenuItem Puestos;
        private System.Windows.Forms.ToolStripMenuItem ReportePlanillas;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}