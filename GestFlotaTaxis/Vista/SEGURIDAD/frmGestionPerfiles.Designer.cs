namespace Vista.SEGURIDAD
{
    partial class frmGestionPerfiles
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionPerfiles));
            this.lblSinResultados = new System.Windows.Forms.Label();
            this.grillaPerfiles = new System.Windows.Forms.DataGridView();
            this.bdsPerfiles = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxGrupo = new System.Windows.Forms.ComboBox();
            this.bdsGrupos = new System.Windows.Forms.BindingSource(this.components);
            this.cbxPermiso = new System.Windows.Forms.ComboBox();
            this.bdsPermisos = new System.Windows.Forms.BindingSource(this.components);
            this.cbxFormulario = new System.Windows.Forms.ComboBox();
            this.bdsFormularios = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.IDgrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDpermiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDformulario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPerfiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPerfiles)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsFormularios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSinResultados
            // 
            this.lblSinResultados.AutoSize = true;
            this.lblSinResultados.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblSinResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinResultados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSinResultados.Location = new System.Drawing.Point(127, 198);
            this.lblSinResultados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSinResultados.Name = "lblSinResultados";
            this.lblSinResultados.Size = new System.Drawing.Size(363, 13);
            this.lblSinResultados.TabIndex = 41;
            this.lblSinResultados.Text = "No se encontraron resultados con los parámetros de busqueda introducidos";
            this.lblSinResultados.Visible = false;
            // 
            // grillaPerfiles
            // 
            this.grillaPerfiles.AllowUserToAddRows = false;
            this.grillaPerfiles.AllowUserToDeleteRows = false;
            this.grillaPerfiles.AutoGenerateColumns = false;
            this.grillaPerfiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grillaPerfiles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grillaPerfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grillaPerfiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDgrupo,
            this.IDpermiso,
            this.IDformulario});
            this.grillaPerfiles.DataSource = this.bdsPerfiles;
            this.grillaPerfiles.Location = new System.Drawing.Point(30, 139);
            this.grillaPerfiles.MultiSelect = false;
            this.grillaPerfiles.Name = "grillaPerfiles";
            this.grillaPerfiles.ReadOnly = true;
            this.grillaPerfiles.RowHeadersVisible = false;
            this.grillaPerfiles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grillaPerfiles.RowTemplate.Height = 24;
            this.grillaPerfiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grillaPerfiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaPerfiles.ShowCellErrors = false;
            this.grillaPerfiles.ShowCellToolTips = false;
            this.grillaPerfiles.ShowEditingIcon = false;
            this.grillaPerfiles.ShowRowErrors = false;
            this.grillaPerfiles.Size = new System.Drawing.Size(534, 231);
            this.grillaPerfiles.TabIndex = 40;
            // 
            // bdsPerfiles
            // 
            this.bdsPerfiles.DataSource = typeof(Modelo.SEGURIDAD.Perfil);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(472, 384);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 42);
            this.btnCancelar.TabIndex = 39;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(360, 384);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 42);
            this.btnEliminar.TabIndex = 38;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(248, 384);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(99, 42);
            this.btnNuevo.TabIndex = 35;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxGrupo);
            this.groupBox1.Controls.Add(this.cbxPermiso);
            this.groupBox1.Controls.Add(this.cbxFormulario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Location = new System.Drawing.Point(13, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 117);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda de Perfiles";
            // 
            // cbxGrupo
            // 
            this.cbxGrupo.DataSource = this.bdsGrupos;
            this.cbxGrupo.DisplayMember = "IDgrupo";
            this.cbxGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGrupo.FormattingEnabled = true;
            this.cbxGrupo.Location = new System.Drawing.Point(164, 20);
            this.cbxGrupo.Name = "cbxGrupo";
            this.cbxGrupo.Size = new System.Drawing.Size(121, 21);
            this.cbxGrupo.TabIndex = 26;
            // 
            // bdsGrupos
            // 
            this.bdsGrupos.DataSource = typeof(Modelo.SEGURIDAD.Grupo);
            // 
            // cbxPermiso
            // 
            this.cbxPermiso.DataSource = this.bdsPermisos;
            this.cbxPermiso.DisplayMember = "IDpermiso";
            this.cbxPermiso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPermiso.FormattingEnabled = true;
            this.cbxPermiso.Location = new System.Drawing.Point(164, 49);
            this.cbxPermiso.Name = "cbxPermiso";
            this.cbxPermiso.Size = new System.Drawing.Size(121, 21);
            this.cbxPermiso.TabIndex = 25;
            this.cbxPermiso.ValueMember = "IDpermiso";
            // 
            // bdsPermisos
            // 
            this.bdsPermisos.DataSource = typeof(Modelo.SEGURIDAD.Permiso);
            // 
            // cbxFormulario
            // 
            this.cbxFormulario.DataSource = this.bdsFormularios;
            this.cbxFormulario.DisplayMember = "IDformulario";
            this.cbxFormulario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFormulario.FormattingEnabled = true;
            this.cbxFormulario.Location = new System.Drawing.Point(164, 77);
            this.cbxFormulario.Name = "cbxFormulario";
            this.cbxFormulario.Size = new System.Drawing.Size(121, 21);
            this.cbxFormulario.TabIndex = 24;
            this.cbxFormulario.ValueMember = "IDformulario";
            // 
            // bdsFormularios
            // 
            this.bdsFormularios.DataSource = typeof(Modelo.SEGURIDAD.Formulario);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Formulario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Permiso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Grupo";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(340, 39);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(99, 42);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(452, 39);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(99, 42);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // IDgrupo
            // 
            this.IDgrupo.DataPropertyName = "IDgrupo";
            this.IDgrupo.HeaderText = "Grupo";
            this.IDgrupo.Name = "IDgrupo";
            this.IDgrupo.ReadOnly = true;
            // 
            // IDpermiso
            // 
            this.IDpermiso.DataPropertyName = "IDpermiso";
            this.IDpermiso.HeaderText = "Permiso";
            this.IDpermiso.Name = "IDpermiso";
            this.IDpermiso.ReadOnly = true;
            // 
            // IDformulario
            // 
            this.IDformulario.DataPropertyName = "IDformulario";
            this.IDformulario.HeaderText = "Formulario";
            this.IDformulario.Name = "IDformulario";
            this.IDformulario.ReadOnly = true;
            // 
            // frmGestPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 435);
            this.Controls.Add(this.lblSinResultados);
            this.Controls.Add(this.grillaPerfiles);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmGestPerfiles";
            this.Text = "Gestion de Perfiles";
            this.Load += new System.EventHandler(this.frmGestPerfiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaPerfiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPerfiles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsFormularios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSinResultados;
        private System.Windows.Forms.DataGridView grillaPerfiles;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox cbxGrupo;
        private System.Windows.Forms.ComboBox cbxPermiso;
        private System.Windows.Forms.ComboBox cbxFormulario;
        private System.Windows.Forms.BindingSource bdsGrupos;
        private System.Windows.Forms.BindingSource bdsPerfiles;
        private System.Windows.Forms.BindingSource bdsPermisos;
        private System.Windows.Forms.BindingSource bdsFormularios;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDgrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDpermiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDformulario;
    }
}