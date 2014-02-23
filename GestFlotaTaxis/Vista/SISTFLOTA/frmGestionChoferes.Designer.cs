namespace Vista
{
    partial class frmGestionChoferes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionVehiculos));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpVehiculos = new System.Windows.Forms.GroupBox();
            this.lblSinResultados = new System.Windows.Forms.Label();
            this.grillaVehiculos = new System.Windows.Forms.DataGridView();
            this.patenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patenteTaxiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.añoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilometrajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsVehiculos = new System.Windows.Forms.BindingSource(this.components);
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.txtAñoFiltro = new System.Windows.Forms.MaskedTextBox();
            this.txtPatenteFiltro = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtPatenteTaxiFiltro = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMarcaFiltro = new System.Windows.Forms.TextBox();
            this.grpVehiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVehiculos)).BeginInit();
            this.grpFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(487, 456);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 42);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grpVehiculos
            // 
            this.grpVehiculos.Controls.Add(this.lblSinResultados);
            this.grpVehiculos.Controls.Add(this.grillaVehiculos);
            this.grpVehiculos.Location = new System.Drawing.Point(18, 154);
            this.grpVehiculos.Margin = new System.Windows.Forms.Padding(2);
            this.grpVehiculos.Name = "grpVehiculos";
            this.grpVehiculos.Padding = new System.Windows.Forms.Padding(2);
            this.grpVehiculos.Size = new System.Drawing.Size(586, 288);
            this.grpVehiculos.TabIndex = 99;
            this.grpVehiculos.TabStop = false;
            this.grpVehiculos.Text = "Choferes";
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
            this.patenteDataGridViewTextBoxColumn,
            this.patenteTaxiDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.añoDataGridViewTextBoxColumn,
            this.kilometrajeDataGridViewTextBoxColumn});
            this.grillaVehiculos.DataSource = this.bdsVehiculos;
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
            // patenteDataGridViewTextBoxColumn
            // 
            this.patenteDataGridViewTextBoxColumn.DataPropertyName = "Patente";
            this.patenteDataGridViewTextBoxColumn.FillWeight = 92.86091F;
            this.patenteDataGridViewTextBoxColumn.HeaderText = "Patente";
            this.patenteDataGridViewTextBoxColumn.Name = "patenteDataGridViewTextBoxColumn";
            this.patenteDataGridViewTextBoxColumn.ReadOnly = true;
            this.patenteDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // patenteTaxiDataGridViewTextBoxColumn
            // 
            this.patenteTaxiDataGridViewTextBoxColumn.DataPropertyName = "PatenteTaxi";
            this.patenteTaxiDataGridViewTextBoxColumn.FillWeight = 84.19932F;
            this.patenteTaxiDataGridViewTextBoxColumn.HeaderText = "PatenteTaxi";
            this.patenteTaxiDataGridViewTextBoxColumn.Name = "patenteTaxiDataGridViewTextBoxColumn";
            this.patenteTaxiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.FillWeight = 169.2586F;
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // añoDataGridViewTextBoxColumn
            // 
            this.añoDataGridViewTextBoxColumn.DataPropertyName = "Año";
            this.añoDataGridViewTextBoxColumn.FillWeight = 52.15835F;
            this.añoDataGridViewTextBoxColumn.HeaderText = "Año";
            this.añoDataGridViewTextBoxColumn.Name = "añoDataGridViewTextBoxColumn";
            this.añoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kilometrajeDataGridViewTextBoxColumn
            // 
            this.kilometrajeDataGridViewTextBoxColumn.DataPropertyName = "Kilometraje";
            this.kilometrajeDataGridViewTextBoxColumn.FillWeight = 101.5229F;
            this.kilometrajeDataGridViewTextBoxColumn.HeaderText = "Kilometraje";
            this.kilometrajeDataGridViewTextBoxColumn.Name = "kilometrajeDataGridViewTextBoxColumn";
            this.kilometrajeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bdsVehiculos
            // 
            this.bdsVehiculos.DataSource = typeof(Modelo.Vehiculo);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(40, 456);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(99, 42);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(262, 456);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(99, 42);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(375, 456);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 42);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(151, 456);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(99, 42);
            this.btnConsultar.TabIndex = 9;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // grpFiltros
            // 
            this.grpFiltros.Controls.Add(this.txtAñoFiltro);
            this.grpFiltros.Controls.Add(this.txtPatenteFiltro);
            this.grpFiltros.Controls.Add(this.btnBuscar);
            this.grpFiltros.Controls.Add(this.txtPatenteTaxiFiltro);
            this.grpFiltros.Controls.Add(this.btnLimpiar);
            this.grpFiltros.Controls.Add(this.label6);
            this.grpFiltros.Controls.Add(this.label5);
            this.grpFiltros.Controls.Add(this.label2);
            this.grpFiltros.Controls.Add(this.label1);
            this.grpFiltros.Controls.Add(this.txtMarcaFiltro);
            this.grpFiltros.Location = new System.Drawing.Point(18, 12);
            this.grpFiltros.Margin = new System.Windows.Forms.Padding(2);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Padding = new System.Windows.Forms.Padding(2);
            this.grpFiltros.Size = new System.Drawing.Size(587, 138);
            this.grpFiltros.TabIndex = 99;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Busqueda de Choferes";
            // 
            // txtAñoFiltro
            // 
            this.txtAñoFiltro.Location = new System.Drawing.Point(307, 25);
            this.txtAñoFiltro.Mask = "0000";
            this.txtAñoFiltro.Name = "txtAñoFiltro";
            this.txtAñoFiltro.PromptChar = ' ';
            this.txtAñoFiltro.Size = new System.Drawing.Size(31, 20);
            this.txtAñoFiltro.TabIndex = 2;
            // 
            // txtPatenteFiltro
            // 
            this.txtPatenteFiltro.Location = new System.Drawing.Point(183, 25);
            this.txtPatenteFiltro.Mask = "AAA-000";
            this.txtPatenteFiltro.Name = "txtPatenteFiltro";
            this.txtPatenteFiltro.PromptChar = ' ';
            this.txtPatenteFiltro.Size = new System.Drawing.Size(48, 20);
            this.txtPatenteFiltro.TabIndex = 1;
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
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtPatenteTaxiFiltro
            // 
            this.txtPatenteTaxiFiltro.Location = new System.Drawing.Point(183, 51);
            this.txtPatenteTaxiFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.txtPatenteTaxiFiltro.MaxLength = 5;
            this.txtPatenteTaxiFiltro.Name = "txtPatenteTaxiFiltro";
            this.txtPatenteTaxiFiltro.Size = new System.Drawing.Size(48, 20);
            this.txtPatenteTaxiFiltro.TabIndex = 3;
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
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(265, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(276, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Año";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Patente Taxi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Patente";
            // 
            // txtMarcaFiltro
            // 
            this.txtMarcaFiltro.Location = new System.Drawing.Point(307, 51);
            this.txtMarcaFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.txtMarcaFiltro.MaxLength = 25;
            this.txtMarcaFiltro.Name = "txtMarcaFiltro";
            this.txtMarcaFiltro.Size = new System.Drawing.Size(90, 20);
            this.txtMarcaFiltro.TabIndex = 4;
            // 
            // frmGestionChoferes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 510);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.grpVehiculos);
            this.Controls.Add(this.grpFiltros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGestionChoferes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion de Choferes";
            this.Load += new System.EventHandler(this.frmGestVehiculos_Load);
            this.grpVehiculos.ResumeLayout(false);
            this.grpVehiculos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVehiculos)).EndInit();
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox grpVehiculos;
        private System.Windows.Forms.DataGridView grillaVehiculos;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarcaFiltro;
        private System.Windows.Forms.MaskedTextBox txtAñoFiltro;
        private System.Windows.Forms.MaskedTextBox txtPatenteFiltro;
        private System.Windows.Forms.TextBox txtPatenteTaxiFiltro;
        private System.Windows.Forms.BindingSource bdsVehiculos;
        private System.Windows.Forms.Label lblSinResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn patenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patenteTaxiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn añoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilometrajeDataGridViewTextBoxColumn;
    }
}