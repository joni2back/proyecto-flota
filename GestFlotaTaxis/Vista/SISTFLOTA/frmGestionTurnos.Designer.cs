namespace Vista
{
    partial class frmGestionTurnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionTurnos));
            this.bdsVehiculos = new System.Windows.Forms.BindingSource(this.components);
            this.bdsChoferes = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.grpTurnos = new System.Windows.Forms.GroupBox();
            this.lblSinResultados = new System.Windows.Forms.Label();
            this.grillaTurnos = new System.Windows.Forms.DataGridView();
            this.TipoGasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxChoferFiltro = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdFiltro = new System.Windows.Forms.MaskedTextBox();
            this.chkFechasFiltro = new System.Windows.Forms.CheckBox();
            this.grpFechasFiltro = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaHastaFiltro = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesdeFiltro = new System.Windows.Forms.DateTimePicker();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTurnoFiltro = new System.Windows.Forms.ComboBox();
            this.cbxVehiculoFiltro = new System.Windows.Forms.ComboBox();
            this.bdsTurnos = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bdsVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChoferes)).BeginInit();
            this.grpTurnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTurnos)).BeginInit();
            this.grpFiltros.SuspendLayout();
            this.grpFechasFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // bdsVehiculos
            // 
            this.bdsVehiculos.DataSource = typeof(Modelo.Vehiculo);
            // 
            // bdsChoferes
            // 
            this.bdsChoferes.DataSource = typeof(Modelo.Chofer);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(631, 441);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 42);
            this.btnCancelar.TabIndex = 104;
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
            this.btnEliminar.Location = new System.Drawing.Point(631, 387);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(123, 42);
            this.btnEliminar.TabIndex = 103;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(631, 332);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(123, 42);
            this.btnModificar.TabIndex = 102;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(631, 277);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(123, 42);
            this.btnConsultar.TabIndex = 101;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(631, 43);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(123, 159);
            this.btnNuevo.TabIndex = 100;
            this.btnNuevo.Text = "Registrar\r\n Nuevo Turno";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // grpTurnos
            // 
            this.grpTurnos.Controls.Add(this.lblSinResultados);
            this.grpTurnos.Controls.Add(this.grillaTurnos);
            this.grpTurnos.Location = new System.Drawing.Point(16, 217);
            this.grpTurnos.Margin = new System.Windows.Forms.Padding(2);
            this.grpTurnos.Name = "grpTurnos";
            this.grpTurnos.Padding = new System.Windows.Forms.Padding(2);
            this.grpTurnos.Size = new System.Drawing.Size(584, 288);
            this.grpTurnos.TabIndex = 106;
            this.grpTurnos.TabStop = false;
            this.grpTurnos.Text = "Turnos Anteriores";
            // 
            // lblSinResultados
            // 
            this.lblSinResultados.AutoSize = true;
            this.lblSinResultados.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblSinResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinResultados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSinResultados.Location = new System.Drawing.Point(125, 58);
            this.lblSinResultados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSinResultados.Name = "lblSinResultados";
            this.lblSinResultados.Size = new System.Drawing.Size(363, 13);
            this.lblSinResultados.TabIndex = 23;
            this.lblSinResultados.Text = "No se encontraron resultados con los parámetros de busqueda introducidos";
            this.lblSinResultados.Visible = false;
            // 
            // grillaTurnos
            // 
            this.grillaTurnos.AllowUserToAddRows = false;
            this.grillaTurnos.AllowUserToDeleteRows = false;
            this.grillaTurnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grillaTurnos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grillaTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grillaTurnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoGasto});
            this.grillaTurnos.Location = new System.Drawing.Point(26, 18);
            this.grillaTurnos.MultiSelect = false;
            this.grillaTurnos.Name = "grillaTurnos";
            this.grillaTurnos.ReadOnly = true;
            this.grillaTurnos.RowHeadersVisible = false;
            this.grillaTurnos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grillaTurnos.RowTemplate.Height = 24;
            this.grillaTurnos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grillaTurnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaTurnos.ShowCellErrors = false;
            this.grillaTurnos.ShowCellToolTips = false;
            this.grillaTurnos.ShowEditingIcon = false;
            this.grillaTurnos.ShowRowErrors = false;
            this.grillaTurnos.Size = new System.Drawing.Size(534, 248);
            this.grillaTurnos.TabIndex = 12;
            // 
            // TipoGasto
            // 
            this.TipoGasto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TipoGasto.DataPropertyName = "TipoGasto";
            this.TipoGasto.FillWeight = 113.2629F;
            this.TipoGasto.Frozen = true;
            this.TipoGasto.HeaderText = "Tipo";
            this.TipoGasto.Name = "TipoGasto";
            this.TipoGasto.ReadOnly = true;
            this.TipoGasto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TipoGasto.Width = 80;
            // 
            // grpFiltros
            // 
            this.grpFiltros.Controls.Add(this.label2);
            this.grpFiltros.Controls.Add(this.cbxChoferFiltro);
            this.grpFiltros.Controls.Add(this.label8);
            this.grpFiltros.Controls.Add(this.txtIdFiltro);
            this.grpFiltros.Controls.Add(this.chkFechasFiltro);
            this.grpFiltros.Controls.Add(this.grpFechasFiltro);
            this.grpFiltros.Controls.Add(this.btnLimpiar);
            this.grpFiltros.Controls.Add(this.btnBuscar);
            this.grpFiltros.Controls.Add(this.label3);
            this.grpFiltros.Controls.Add(this.label1);
            this.grpFiltros.Controls.Add(this.cbxTurnoFiltro);
            this.grpFiltros.Controls.Add(this.cbxVehiculoFiltro);
            this.grpFiltros.Location = new System.Drawing.Point(16, 18);
            this.grpFiltros.Margin = new System.Windows.Forms.Padding(2);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Padding = new System.Windows.Forms.Padding(2);
            this.grpFiltros.Size = new System.Drawing.Size(584, 195);
            this.grpFiltros.TabIndex = 105;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Busqueda de Turnos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 101;
            this.label2.Text = "Chofer";
            // 
            // cbxChoferFiltro
            // 
            this.cbxChoferFiltro.DataSource = this.bdsChoferes;
            this.cbxChoferFiltro.DisplayMember = "Apellido";
            this.cbxChoferFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChoferFiltro.FormattingEnabled = true;
            this.cbxChoferFiltro.Location = new System.Drawing.Point(130, 87);
            this.cbxChoferFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.cbxChoferFiltro.Name = "cbxChoferFiltro";
            this.cbxChoferFiltro.Size = new System.Drawing.Size(137, 21);
            this.cbxChoferFiltro.TabIndex = 100;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Numero de Turno";
            // 
            // txtIdFiltro
            // 
            this.txtIdFiltro.Location = new System.Drawing.Point(130, 27);
            this.txtIdFiltro.Mask = "99999999999";
            this.txtIdFiltro.Name = "txtIdFiltro";
            this.txtIdFiltro.PromptChar = ' ';
            this.txtIdFiltro.Size = new System.Drawing.Size(137, 20);
            this.txtIdFiltro.TabIndex = 1;
            // 
            // chkFechasFiltro
            // 
            this.chkFechasFiltro.AutoSize = true;
            this.chkFechasFiltro.Location = new System.Drawing.Point(300, 25);
            this.chkFechasFiltro.Name = "chkFechasFiltro";
            this.chkFechasFiltro.Size = new System.Drawing.Size(15, 14);
            this.chkFechasFiltro.TabIndex = 7;
            this.chkFechasFiltro.UseVisualStyleBackColor = true;
            this.chkFechasFiltro.CheckedChanged += new System.EventHandler(this.chkFechasFiltro_CheckedChanged);
            // 
            // grpFechasFiltro
            // 
            this.grpFechasFiltro.Controls.Add(this.label7);
            this.grpFechasFiltro.Controls.Add(this.label4);
            this.grpFechasFiltro.Controls.Add(this.dtpFechaHastaFiltro);
            this.grpFechasFiltro.Controls.Add(this.dtpFechaDesdeFiltro);
            this.grpFechasFiltro.Enabled = false;
            this.grpFechasFiltro.Location = new System.Drawing.Point(289, 27);
            this.grpFechasFiltro.Name = "grpFechasFiltro";
            this.grpFechasFiltro.Size = new System.Drawing.Size(243, 88);
            this.grpFechasFiltro.TabIndex = 99;
            this.grpFechasFiltro.TabStop = false;
            this.grpFechasFiltro.Text = "       Filtrar por fechas de turno";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 57);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha Hasta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha Desde";
            // 
            // dtpFechaHastaFiltro
            // 
            this.dtpFechaHastaFiltro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHastaFiltro.Location = new System.Drawing.Point(133, 55);
            this.dtpFechaHastaFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaHastaFiltro.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.dtpFechaHastaFiltro.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaHastaFiltro.Name = "dtpFechaHastaFiltro";
            this.dtpFechaHastaFiltro.Size = new System.Drawing.Size(90, 20);
            this.dtpFechaHastaFiltro.TabIndex = 9;
            this.dtpFechaHastaFiltro.Value = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            // 
            // dtpFechaDesdeFiltro
            // 
            this.dtpFechaDesdeFiltro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesdeFiltro.Location = new System.Drawing.Point(133, 21);
            this.dtpFechaDesdeFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaDesdeFiltro.MaxDate = new System.DateTime(2998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaDesdeFiltro.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaDesdeFiltro.Name = "dtpFechaDesdeFiltro";
            this.dtpFechaDesdeFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpFechaDesdeFiltro.Size = new System.Drawing.Size(90, 20);
            this.dtpFechaDesdeFiltro.TabIndex = 8;
            this.dtpFechaDesdeFiltro.Value = new System.DateTime(2012, 6, 4, 0, 0, 0, 0);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(433, 135);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(99, 42);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(322, 135);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(99, 42);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Turno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vehiculo";
            // 
            // cbxTurnoFiltro
            // 
            this.cbxTurnoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTurnoFiltro.FormattingEnabled = true;
            this.cbxTurnoFiltro.Location = new System.Drawing.Point(128, 115);
            this.cbxTurnoFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.cbxTurnoFiltro.Name = "cbxTurnoFiltro";
            this.cbxTurnoFiltro.Size = new System.Drawing.Size(90, 21);
            this.cbxTurnoFiltro.TabIndex = 6;
            // 
            // cbxVehiculoFiltro
            // 
            this.cbxVehiculoFiltro.DataSource = this.bdsVehiculos;
            this.cbxVehiculoFiltro.DisplayMember = "Patente";
            this.cbxVehiculoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVehiculoFiltro.FormattingEnabled = true;
            this.cbxVehiculoFiltro.Location = new System.Drawing.Point(130, 56);
            this.cbxVehiculoFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.cbxVehiculoFiltro.Name = "cbxVehiculoFiltro";
            this.cbxVehiculoFiltro.Size = new System.Drawing.Size(137, 21);
            this.cbxVehiculoFiltro.TabIndex = 3;
            // 
            // bdsTurnos
            // 
            this.bdsTurnos.DataSource = typeof(Modelo.Turno);
            // 
            // frmGestionTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 521);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.grpTurnos);
            this.Controls.Add(this.grpFiltros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGestionTurnos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion de Turnos";
            this.Load += new System.EventHandler(this.frmGestionTurnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChoferes)).EndInit();
            this.grpTurnos.ResumeLayout(false);
            this.grpTurnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTurnos)).EndInit();
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            this.grpFechasFiltro.ResumeLayout(false);
            this.grpFechasFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTurnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bdsChoferes;
        private System.Windows.Forms.BindingSource bdsVehiculos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox grpTurnos;
        private System.Windows.Forms.Label lblSinResultados;
        private System.Windows.Forms.DataGridView grillaTurnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoGasto;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxChoferFiltro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtIdFiltro;
        private System.Windows.Forms.CheckBox chkFechasFiltro;
        private System.Windows.Forms.GroupBox grpFechasFiltro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaHastaFiltro;
        private System.Windows.Forms.DateTimePicker dtpFechaDesdeFiltro;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTurnoFiltro;
        private System.Windows.Forms.ComboBox cbxVehiculoFiltro;
        private System.Windows.Forms.BindingSource bdsTurnos;
    }
}