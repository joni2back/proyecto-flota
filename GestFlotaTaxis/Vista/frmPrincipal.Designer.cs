namespace Vista
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCambiarContraseña = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGestionar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGestVehiculos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGestGastos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMonitores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMonGastos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInformes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdministrar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdmUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdmGrupos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdmPerfiles = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAuditoria = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAudLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.gastosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAcercade = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuarioActual = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNomyApeActual = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuGestChoferes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.SystemColors.Control;
            this.menuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuPrincipal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSistema,
            this.menuGestionar,
            this.menuMonitores,
            this.menuInformes,
            this.menuAdministrar,
            this.menuAuditoria,
            this.menuAyuda});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuPrincipal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuPrincipal.Size = new System.Drawing.Size(867, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuPrincipal";
            // 
            // menuSistema
            // 
            this.menuSistema.BackColor = System.Drawing.SystemColors.Control;
            this.menuSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCambiarContraseña,
            this.menuCerrarSesion,
            this.menuSalir});
            this.menuSistema.Name = "menuSistema";
            this.menuSistema.Size = new System.Drawing.Size(62, 20);
            this.menuSistema.Text = "Sistema";
            // 
            // menuCambiarContraseña
            // 
            this.menuCambiarContraseña.Name = "menuCambiarContraseña";
            this.menuCambiarContraseña.Size = new System.Drawing.Size(184, 22);
            this.menuCambiarContraseña.Text = "Cambiar Contraseña";
            this.menuCambiarContraseña.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // menuCerrarSesion
            // 
            this.menuCerrarSesion.Name = "menuCerrarSesion";
            this.menuCerrarSesion.Size = new System.Drawing.Size(184, 22);
            this.menuCerrarSesion.Text = "Cerrar Sesión";
            this.menuCerrarSesion.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // menuSalir
            // 
            this.menuSalir.Name = "menuSalir";
            this.menuSalir.Size = new System.Drawing.Size(184, 22);
            this.menuSalir.Text = "Salir";
            this.menuSalir.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // menuGestionar
            // 
            this.menuGestionar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGestChoferes,
            this.menuGestGastos,
            this.menuGestVehiculos});
            this.menuGestionar.Name = "menuGestionar";
            this.menuGestionar.Size = new System.Drawing.Size(72, 20);
            this.menuGestionar.Text = "Gestionar";
            // 
            // menuGestVehiculos
            // 
            this.menuGestVehiculos.Name = "menuGestVehiculos";
            this.menuGestVehiculos.Size = new System.Drawing.Size(152, 22);
            this.menuGestVehiculos.Text = "Vehículos";
            this.menuGestVehiculos.Click += new System.EventHandler(this.vehículosToolStripMenuItem_Click);
            // 
            // menuGestGastos
            // 
            this.menuGestGastos.Name = "menuGestGastos";
            this.menuGestGastos.Size = new System.Drawing.Size(152, 22);
            this.menuGestGastos.Text = "Gastos";
            this.menuGestGastos.Click += new System.EventHandler(this.gastosToolStripMenuItem_Click);
            // 
            // menuMonitores
            // 
            this.menuMonitores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMonGastos});
            this.menuMonitores.Name = "menuMonitores";
            this.menuMonitores.Size = new System.Drawing.Size(76, 20);
            this.menuMonitores.Text = "Monitores";
            // 
            // menuMonGastos
            // 
            this.menuMonGastos.Name = "menuMonGastos";
            this.menuMonGastos.Size = new System.Drawing.Size(110, 22);
            this.menuMonGastos.Text = "Gastos";
            this.menuMonGastos.Click += new System.EventHandler(this.gastosToolStripMenuItem1_Click);
            // 
            // menuInformes
            // 
            this.menuInformes.Name = "menuInformes";
            this.menuInformes.Size = new System.Drawing.Size(68, 20);
            this.menuInformes.Text = "Informes";
            this.menuInformes.Click += new System.EventHandler(this.informesToolStripMenuItem_Click);
            // 
            // menuAdministrar
            // 
            this.menuAdministrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdmUsuarios,
            this.menuAdmGrupos,
            this.menuAdmPerfiles});
            this.menuAdministrar.Name = "menuAdministrar";
            this.menuAdministrar.Size = new System.Drawing.Size(84, 20);
            this.menuAdministrar.Text = "Administrar";
            this.menuAdministrar.Visible = false;
            // 
            // menuAdmUsuarios
            // 
            this.menuAdmUsuarios.Name = "menuAdmUsuarios";
            this.menuAdmUsuarios.Size = new System.Drawing.Size(120, 22);
            this.menuAdmUsuarios.Text = "Usuarios";
            this.menuAdmUsuarios.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // menuAdmGrupos
            // 
            this.menuAdmGrupos.Name = "menuAdmGrupos";
            this.menuAdmGrupos.Size = new System.Drawing.Size(120, 22);
            this.menuAdmGrupos.Text = "Grupos";
            this.menuAdmGrupos.Click += new System.EventHandler(this.gruposToolStripMenuItem_Click);
            // 
            // menuAdmPerfiles
            // 
            this.menuAdmPerfiles.Name = "menuAdmPerfiles";
            this.menuAdmPerfiles.Size = new System.Drawing.Size(120, 22);
            this.menuAdmPerfiles.Text = "Perfiles";
            this.menuAdmPerfiles.Click += new System.EventHandler(this.perfilesToolStripMenuItem_Click);
            // 
            // menuAuditoria
            // 
            this.menuAuditoria.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAudLogs,
            this.gastosToolStripMenuItem});
            this.menuAuditoria.Name = "menuAuditoria";
            this.menuAuditoria.Size = new System.Drawing.Size(70, 20);
            this.menuAuditoria.Text = "Auditoria";
            this.menuAuditoria.Visible = false;
            // 
            // menuAudLogs
            // 
            this.menuAudLogs.Name = "menuAudLogs";
            this.menuAudLogs.Size = new System.Drawing.Size(149, 22);
            this.menuAudLogs.Text = "LogIn/LogOut";
            this.menuAudLogs.Click += new System.EventHandler(this.menuAudLogs_Click);
            // 
            // gastosToolStripMenuItem
            // 
            this.gastosToolStripMenuItem.Name = "gastosToolStripMenuItem";
            this.gastosToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.gastosToolStripMenuItem.Text = "Gastos";
            this.gastosToolStripMenuItem.Click += new System.EventHandler(this.gastosToolStripMenuItem_Click_1);
            // 
            // menuAyuda
            // 
            this.menuAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAcercade});
            this.menuAyuda.Name = "menuAyuda";
            this.menuAyuda.Size = new System.Drawing.Size(53, 20);
            this.menuAyuda.Text = "Ayuda";
            // 
            // menuAcercade
            // 
            this.menuAcercade.Name = "menuAcercade";
            this.menuAcercade.Size = new System.Drawing.Size(156, 22);
            this.menuAcercade.Text = "Acerca de SGFT";
            this.menuAcercade.Click += new System.EventHandler(this.acercaDeSGFTToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(100, 50, 50, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 491);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(691, 412);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(176, 99);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(437, 108);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(397, 198);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSalir.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(539, 455);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(122, 42);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(408, 455);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(122, 42);
            this.btnCerrarSesion.TabIndex = 21;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblFecha,
            this.toolStripStatusLabel2,
            this.lblHora,
            this.toolStripStatusLabel3,
            this.lblUsuarioActual,
            this.toolStripStatusLabel4,
            this.lblNomyApeActual});
            this.statusStrip1.Location = new System.Drawing.Point(0, 515);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(867, 22);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(41, 17);
            this.toolStripStatusLabel1.Text = "Fecha:";
            // 
            // lblFecha
            // 
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(12, 17);
            this.lblFecha.Text = "-";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(60, 17);
            this.toolStripStatusLabel2.Text = "        Hora:";
            // 
            // lblHora
            // 
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(12, 17);
            this.lblHora.Text = "-";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(107, 17);
            this.toolStripStatusLabel3.Text = "            |      Usuario:";
            // 
            // lblUsuarioActual
            // 
            this.lblUsuarioActual.Name = "lblUsuarioActual";
            this.lblUsuarioActual.Size = new System.Drawing.Size(12, 17);
            this.lblUsuarioActual.Text = "-";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(72, 17);
            this.toolStripStatusLabel4.Text = "          -          ";
            // 
            // lblNomyApeActual
            // 
            this.lblNomyApeActual.Name = "lblNomyApeActual";
            this.lblNomyApeActual.Size = new System.Drawing.Size(12, 17);
            this.lblNomyApeActual.Text = "-";
            // 
            // menuGestChoferes
            // 
            this.menuGestChoferes.Name = "menuGestChoferes";
            this.menuGestChoferes.Size = new System.Drawing.Size(152, 22);
            this.menuGestChoferes.Text = "Choferes";
            this.menuGestChoferes.Click += new System.EventHandler(this.menuGestChoferes_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 537);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuPrincipal);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(873, 564);
            this.Name = "frmPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "SGFT - Sistema Gestion Flota de Taxis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuSistema;
        private System.Windows.Forms.ToolStripMenuItem menuSalir;
        private System.Windows.Forms.ToolStripMenuItem menuGestionar;
        private System.Windows.Forms.ToolStripMenuItem menuGestVehiculos;
        private System.Windows.Forms.ToolStripMenuItem menuGestGastos;
        private System.Windows.Forms.ToolStripMenuItem menuMonitores;
        private System.Windows.Forms.ToolStripMenuItem menuMonGastos;
        private System.Windows.Forms.ToolStripMenuItem menuInformes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolStripMenuItem menuAyuda;
        private System.Windows.Forms.ToolStripMenuItem menuAcercade;
        private System.Windows.Forms.ToolStripMenuItem menuAdministrar;
        private System.Windows.Forms.ToolStripMenuItem menuAdmUsuarios;
        private System.Windows.Forms.ToolStripMenuItem menuAdmGrupos;
        private System.Windows.Forms.ToolStripMenuItem menuAdmPerfiles;
        private System.Windows.Forms.ToolStripMenuItem menuCerrarSesion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblFecha;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblHora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuarioActual;
        private System.Windows.Forms.ToolStripMenuItem menuCambiarContraseña;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel lblNomyApeActual;
        private System.Windows.Forms.ToolStripMenuItem menuAuditoria;
        private System.Windows.Forms.ToolStripMenuItem menuAudLogs;
        private System.Windows.Forms.ToolStripMenuItem gastosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuGestChoferes;
    }
}

