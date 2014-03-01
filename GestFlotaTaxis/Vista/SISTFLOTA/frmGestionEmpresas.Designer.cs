namespace Vista.SISTFLOTA
{
    partial class frmGestionEmpresas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionEmpresas));
            this.lblSinResultados = new System.Windows.Forms.Label();
            this.grillaVehiculos = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtApellidoFiltro = new System.Windows.Forms.TextBox();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtNombreFiltro = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.grpVehiculos = new System.Windows.Forms.GroupBox();
            this.documentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsChoferes = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grillaVehiculos)).BeginInit();
            this.grpFiltros.SuspendLayout();
            this.grpVehiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChoferes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSinResultados
            // 
            this.lblSinResultados.AutoSize = true;
            this.lblSinResultados.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblSinResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinResultados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSinResultados.Location = new System.Drawing.Point(110, 58);
            this.lblSinResultados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSinResultados.Name = "lblSinResultados";
            this.lblSinResultados.Size = new System.Drawing.Size(363, 13);
            this.lblSinResultados.TabIndex = 22;
            this.lblSinResultados.Text = "No se encontraron resultados con los parámetros de busqueda introducidos";
            this.lblSinResultados.Visible = false;
            // 
            // grillaVehiculos
            // 
            this.grillaVehiculos.AllowUserToAddRows = false;
            this.grillaVehiculos.AllowUserToDeleteRows = false;
            this.grillaVehiculos.AutoGenerateColumns = false;
            this.grillaVehiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grillaVehiculos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grillaVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grillaVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.documentoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.licenciaDataGridViewTextBoxColumn,
            this.domicilioDataGridViewTextBoxColumn,
            this.localidadDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.fechaNacimientoDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.fotoDataGridViewTextBoxColumn});
            this.grillaVehiculos.DataSource = this.bdsChoferes;
            this.grillaVehiculos.Location = new System.Drawing.Point(27, 29);
            this.grillaVehiculos.MultiSelect = false;
            this.grillaVehiculos.Name = "grillaVehiculos";
            this.grillaVehiculos.ReadOnly = true;
            this.grillaVehiculos.RowHeadersVisible = false;
            this.grillaVehiculos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grillaVehiculos.RowTemplate.Height = 24;
            this.grillaVehiculos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grillaVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaVehiculos.ShowCellErrors = false;
            this.grillaVehiculos.ShowCellToolTips = false;
            this.grillaVehiculos.ShowEditingIcon = false;
            this.grillaVehiculos.ShowRowErrors = false;
            this.grillaVehiculos.Size = new System.Drawing.Size(534, 240);
            this.grillaVehiculos.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(478, 446);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 42);
            this.btnCancelar.TabIndex = 111;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(366, 446);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 42);
            this.btnEliminar.TabIndex = 110;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(253, 446);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(99, 42);
            this.btnModificar.TabIndex = 109;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(142, 446);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(99, 42);
            this.btnConsultar.TabIndex = 108;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // txtApellidoFiltro
            // 
            this.txtApellidoFiltro.Location = new System.Drawing.Point(382, 33);
            this.txtApellidoFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidoFiltro.MaxLength = 25;
            this.txtApellidoFiltro.Name = "txtApellidoFiltro";
            this.txtApellidoFiltro.Size = new System.Drawing.Size(142, 20);
            this.txtApellidoFiltro.TabIndex = 37;
            // 
            // grpFiltros
            // 
            this.grpFiltros.Controls.Add(this.txtApellidoFiltro);
            this.grpFiltros.Controls.Add(this.label8);
            this.grpFiltros.Controls.Add(this.label4);
            this.grpFiltros.Controls.Add(this.btnBuscar);
            this.grpFiltros.Controls.Add(this.btnLimpiar);
            this.grpFiltros.Controls.Add(this.txtNombreFiltro);
            this.grpFiltros.Location = new System.Drawing.Point(9, 2);
            this.grpFiltros.Margin = new System.Windows.Forms.Padding(2);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Padding = new System.Windows.Forms.Padding(2);
            this.grpFiltros.Size = new System.Drawing.Size(587, 138);
            this.grpFiltros.TabIndex = 113;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Busqueda de Clientes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(57, 33);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 33;
            this.label8.Text = "Razón Social";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(324, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Teléfono";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(357, 85);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(99, 42);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(469, 85);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(99, 42);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // txtNombreFiltro
            // 
            this.txtNombreFiltro.Location = new System.Drawing.Point(133, 31);
            this.txtNombreFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreFiltro.MaxLength = 25;
            this.txtNombreFiltro.Name = "txtNombreFiltro";
            this.txtNombreFiltro.Size = new System.Drawing.Size(142, 20);
            this.txtNombreFiltro.TabIndex = 1;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(31, 446);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(99, 42);
            this.btnNuevo.TabIndex = 107;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // grpVehiculos
            // 
            this.grpVehiculos.Controls.Add(this.lblSinResultados);
            this.grpVehiculos.Controls.Add(this.grillaVehiculos);
            this.grpVehiculos.Location = new System.Drawing.Point(9, 144);
            this.grpVehiculos.Margin = new System.Windows.Forms.Padding(2);
            this.grpVehiculos.Name = "grpVehiculos";
            this.grpVehiculos.Padding = new System.Windows.Forms.Padding(2);
            this.grpVehiculos.Size = new System.Drawing.Size(586, 288);
            this.grpVehiculos.TabIndex = 112;
            this.grpVehiculos.TabStop = false;
            this.grpVehiculos.Text = "Choferes";
            // 
            // documentoDataGridViewTextBoxColumn
            // 
            this.documentoDataGridViewTextBoxColumn.DataPropertyName = "Documento";
            this.documentoDataGridViewTextBoxColumn.HeaderText = "Documento";
            this.documentoDataGridViewTextBoxColumn.Name = "documentoDataGridViewTextBoxColumn";
            this.documentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // licenciaDataGridViewTextBoxColumn
            // 
            this.licenciaDataGridViewTextBoxColumn.DataPropertyName = "Licencia";
            this.licenciaDataGridViewTextBoxColumn.HeaderText = "Licencia";
            this.licenciaDataGridViewTextBoxColumn.Name = "licenciaDataGridViewTextBoxColumn";
            this.licenciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // domicilioDataGridViewTextBoxColumn
            // 
            this.domicilioDataGridViewTextBoxColumn.DataPropertyName = "Domicilio";
            this.domicilioDataGridViewTextBoxColumn.HeaderText = "Domicilio";
            this.domicilioDataGridViewTextBoxColumn.Name = "domicilioDataGridViewTextBoxColumn";
            this.domicilioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localidadDataGridViewTextBoxColumn
            // 
            this.localidadDataGridViewTextBoxColumn.DataPropertyName = "Localidad";
            this.localidadDataGridViewTextBoxColumn.HeaderText = "Localidad";
            this.localidadDataGridViewTextBoxColumn.Name = "localidadDataGridViewTextBoxColumn";
            this.localidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            this.fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "FechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            this.fechaNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fotoDataGridViewTextBoxColumn
            // 
            this.fotoDataGridViewTextBoxColumn.DataPropertyName = "Foto";
            this.fotoDataGridViewTextBoxColumn.HeaderText = "Foto";
            this.fotoDataGridViewTextBoxColumn.Name = "fotoDataGridViewTextBoxColumn";
            this.fotoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bdsChoferes
            // 
            this.bdsChoferes.DataSource = typeof(Modelo.Chofer);
            // 
            // frmGestionEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 490);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.grpFiltros);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.grpVehiculos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "frmGestionEmpresas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestión de Empresas";
            ((System.ComponentModel.ISupportInitialize)(this.grillaVehiculos)).EndInit();
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            this.grpVehiculos.ResumeLayout(false);
            this.grpVehiculos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChoferes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn fotoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblSinResultados;
        private System.Windows.Forms.DataGridView grillaVehiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bdsChoferes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtApellidoFiltro;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtNombreFiltro;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox grpVehiculos;
    }
}