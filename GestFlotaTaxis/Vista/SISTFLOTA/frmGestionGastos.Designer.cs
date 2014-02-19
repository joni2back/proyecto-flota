namespace Vista
{
    partial class frmGestionGastos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionGastos));
            this.grpFiltros = new System.Windows.Forms.GroupBox();
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMontoFiltro = new System.Windows.Forms.TextBox();
            this.txtDescripcionFiltro = new System.Windows.Forms.TextBox();
            this.cbxEstadoFiltro = new System.Windows.Forms.ComboBox();
            this.cbxTipoGastoFiltro = new System.Windows.Forms.ComboBox();
            this.bdsTipodeGasto = new System.Windows.Forms.BindingSource(this.components);
            this.cbxVehiculoFiltro = new System.Windows.Forms.ComboBox();
            this.bdsVehiculos = new System.Windows.Forms.BindingSource(this.components);
            this.grpGastos = new System.Windows.Forms.GroupBox();
            this.lblSinResultados = new System.Windows.Forms.Label();
            this.grillaVehiculos = new System.Windows.Forms.DataGridView();
            this.bdsGastos = new System.Windows.Forms.BindingSource(this.components);
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoGasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVencimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpFiltros.SuspendLayout();
            this.grpFechasFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTipodeGasto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVehiculos)).BeginInit();
            this.grpGastos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGastos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFiltros
            // 
            this.grpFiltros.Controls.Add(this.label8);
            this.grpFiltros.Controls.Add(this.txtIdFiltro);
            this.grpFiltros.Controls.Add(this.chkFechasFiltro);
            this.grpFiltros.Controls.Add(this.grpFechasFiltro);
            this.grpFiltros.Controls.Add(this.btnLimpiar);
            this.grpFiltros.Controls.Add(this.btnBuscar);
            this.grpFiltros.Controls.Add(this.label6);
            this.grpFiltros.Controls.Add(this.label5);
            this.grpFiltros.Controls.Add(this.label3);
            this.grpFiltros.Controls.Add(this.label2);
            this.grpFiltros.Controls.Add(this.label1);
            this.grpFiltros.Controls.Add(this.txtMontoFiltro);
            this.grpFiltros.Controls.Add(this.txtDescripcionFiltro);
            this.grpFiltros.Controls.Add(this.cbxEstadoFiltro);
            this.grpFiltros.Controls.Add(this.cbxTipoGastoFiltro);
            this.grpFiltros.Controls.Add(this.cbxVehiculoFiltro);
            this.grpFiltros.Location = new System.Drawing.Point(27, 21);
            this.grpFiltros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpFiltros.Size = new System.Drawing.Size(783, 278);
            this.grpFiltros.TabIndex = 99;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Busqueda de Gastos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(107, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Numero";
            // 
            // txtIdFiltro
            // 
            this.txtIdFiltro.Location = new System.Drawing.Point(179, 27);
            this.txtIdFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdFiltro.Mask = "99999999999";
            this.txtIdFiltro.Name = "txtIdFiltro";
            this.txtIdFiltro.PromptChar = ' ';
            this.txtIdFiltro.Size = new System.Drawing.Size(119, 22);
            this.txtIdFiltro.TabIndex = 1;
            // 
            // chkFechasFiltro
            // 
            this.chkFechasFiltro.AutoSize = true;
            this.chkFechasFiltro.Location = new System.Drawing.Point(369, 98);
            this.chkFechasFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkFechasFiltro.Name = "chkFechasFiltro";
            this.chkFechasFiltro.Size = new System.Drawing.Size(18, 17);
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
            this.grpFechasFiltro.Location = new System.Drawing.Point(355, 101);
            this.grpFechasFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpFechasFiltro.Name = "grpFechasFiltro";
            this.grpFechasFiltro.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpFechasFiltro.Size = new System.Drawing.Size(324, 108);
            this.grpFechasFiltro.TabIndex = 99;
            this.grpFechasFiltro.TabStop = false;
            this.grpFechasFiltro.Text = "       Filtrar por fechas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Vencimiento Hasta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Vencimiento Desde";
            // 
            // dtpFechaHastaFiltro
            // 
            this.dtpFechaHastaFiltro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHastaFiltro.Location = new System.Drawing.Point(177, 68);
            this.dtpFechaHastaFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaHastaFiltro.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.dtpFechaHastaFiltro.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaHastaFiltro.Name = "dtpFechaHastaFiltro";
            this.dtpFechaHastaFiltro.Size = new System.Drawing.Size(119, 22);
            this.dtpFechaHastaFiltro.TabIndex = 9;
            this.dtpFechaHastaFiltro.Value = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            // 
            // dtpFechaDesdeFiltro
            // 
            this.dtpFechaDesdeFiltro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesdeFiltro.Location = new System.Drawing.Point(177, 26);
            this.dtpFechaDesdeFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaDesdeFiltro.MaxDate = new System.DateTime(2998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaDesdeFiltro.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaDesdeFiltro.Name = "dtpFechaDesdeFiltro";
            this.dtpFechaDesdeFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpFechaDesdeFiltro.Size = new System.Drawing.Size(119, 22);
            this.dtpFechaDesdeFiltro.TabIndex = 8;
            this.dtpFechaDesdeFiltro.Value = new System.DateTime(2012, 6, 4, 0, 0, 0, 0);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(625, 218);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(132, 52);
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
            this.btnBuscar.Location = new System.Drawing.Point(477, 218);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(132, 52);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(380, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Monto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(345, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tipo de Gasto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vehículo";
            // 
            // txtMontoFiltro
            // 
            this.txtMontoFiltro.Location = new System.Drawing.Point(440, 63);
            this.txtMontoFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMontoFiltro.MaxLength = 7;
            this.txtMontoFiltro.Name = "txtMontoFiltro";
            this.txtMontoFiltro.Size = new System.Drawing.Size(87, 22);
            this.txtMontoFiltro.TabIndex = 4;
            // 
            // txtDescripcionFiltro
            // 
            this.txtDescripcionFiltro.Location = new System.Drawing.Point(440, 26);
            this.txtDescripcionFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcionFiltro.MaxLength = 50;
            this.txtDescripcionFiltro.Name = "txtDescripcionFiltro";
            this.txtDescripcionFiltro.Size = new System.Drawing.Size(237, 22);
            this.txtDescripcionFiltro.TabIndex = 2;
            // 
            // cbxEstadoFiltro
            // 
            this.cbxEstadoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstadoFiltro.FormattingEnabled = true;
            this.cbxEstadoFiltro.Location = new System.Drawing.Point(179, 149);
            this.cbxEstadoFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxEstadoFiltro.Name = "cbxEstadoFiltro";
            this.cbxEstadoFiltro.Size = new System.Drawing.Size(119, 24);
            this.cbxEstadoFiltro.TabIndex = 6;
            // 
            // cbxTipoGastoFiltro
            // 
            this.cbxTipoGastoFiltro.DataSource = this.bdsTipodeGasto;
            this.cbxTipoGastoFiltro.DisplayMember = "Descripcion";
            this.cbxTipoGastoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoGastoFiltro.FormattingEnabled = true;
            this.cbxTipoGastoFiltro.Location = new System.Drawing.Point(179, 110);
            this.cbxTipoGastoFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxTipoGastoFiltro.Name = "cbxTipoGastoFiltro";
            this.cbxTipoGastoFiltro.Size = new System.Drawing.Size(119, 24);
            this.cbxTipoGastoFiltro.TabIndex = 5;
            // 
            // bdsTipodeGasto
            // 
            this.bdsTipodeGasto.DataSource = typeof(Modelo.TipodeGasto);
            // 
            // cbxVehiculoFiltro
            // 
            this.cbxVehiculoFiltro.DataSource = this.bdsVehiculos;
            this.cbxVehiculoFiltro.DisplayMember = "Patente";
            this.cbxVehiculoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVehiculoFiltro.FormattingEnabled = true;
            this.cbxVehiculoFiltro.Location = new System.Drawing.Point(179, 68);
            this.cbxVehiculoFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxVehiculoFiltro.Name = "cbxVehiculoFiltro";
            this.cbxVehiculoFiltro.Size = new System.Drawing.Size(119, 24);
            this.cbxVehiculoFiltro.TabIndex = 3;
            // 
            // bdsVehiculos
            // 
            this.bdsVehiculos.DataSource = typeof(Modelo.Vehiculo);
            // 
            // grpGastos
            // 
            this.grpGastos.Controls.Add(this.lblSinResultados);
            this.grpGastos.Controls.Add(this.grillaVehiculos);
            this.grpGastos.Location = new System.Drawing.Point(28, 304);
            this.grpGastos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpGastos.Name = "grpGastos";
            this.grpGastos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpGastos.Size = new System.Drawing.Size(781, 316);
            this.grpGastos.TabIndex = 99;
            this.grpGastos.TabStop = false;
            this.grpGastos.Text = "Gastos";
            // 
            // lblSinResultados
            // 
            this.lblSinResultados.AutoSize = true;
            this.lblSinResultados.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblSinResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinResultados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSinResultados.Location = new System.Drawing.Point(167, 71);
            this.lblSinResultados.Name = "lblSinResultados";
            this.lblSinResultados.Size = new System.Drawing.Size(489, 17);
            this.lblSinResultados.TabIndex = 23;
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
            this.idDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.TipoGasto,
            this.montoDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.fechaVencimientoDataGridViewTextBoxColumn});
            this.grillaVehiculos.DataSource = this.bdsGastos;
            this.grillaVehiculos.Location = new System.Drawing.Point(35, 22);
            this.grillaVehiculos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.grillaVehiculos.Size = new System.Drawing.Size(712, 284);
            this.grillaVehiculos.TabIndex = 12;
            // 
            // bdsGastos
            // 
            this.bdsGastos.DataSource = typeof(Modelo.Gasto);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(48, 631);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(132, 52);
            this.btnNuevo.TabIndex = 13;
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
            this.btnModificar.Location = new System.Drawing.Point(356, 631);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(132, 52);
            this.btnModificar.TabIndex = 15;
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
            this.btnEliminar.Location = new System.Drawing.Point(504, 631);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(132, 52);
            this.btnEliminar.TabIndex = 16;
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
            this.btnConsultar.Location = new System.Drawing.Point(200, 631);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(132, 52);
            this.btnConsultar.TabIndex = 14;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(652, 631);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 52);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.FillWeight = 50.4806F;
            this.idDataGridViewTextBoxColumn.Frozen = true;
            this.idDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.FillWeight = 218.8785F;
            this.descripcionDataGridViewTextBoxColumn.Frozen = true;
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.descripcionDataGridViewTextBoxColumn.Width = 150;
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
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "Monto";
            this.montoDataGridViewTextBoxColumn.FillWeight = 58.39927F;
            this.montoDataGridViewTextBoxColumn.Frozen = true;
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.ReadOnly = true;
            this.montoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.montoDataGridViewTextBoxColumn.Width = 70;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.FillWeight = 89.71628F;
            this.estadoDataGridViewTextBoxColumn.Frozen = true;
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.estadoDataGridViewTextBoxColumn.Width = 90;
            // 
            // fechaVencimientoDataGridViewTextBoxColumn
            // 
            this.fechaVencimientoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fechaVencimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaVencimiento";
            this.fechaVencimientoDataGridViewTextBoxColumn.FillWeight = 80F;
            this.fechaVencimientoDataGridViewTextBoxColumn.Frozen = true;
            this.fechaVencimientoDataGridViewTextBoxColumn.HeaderText = "Vence/Pago";
            this.fechaVencimientoDataGridViewTextBoxColumn.Name = "fechaVencimientoDataGridViewTextBoxColumn";
            this.fechaVencimientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaVencimientoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // frmGestionGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 694);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.grpGastos);
            this.Controls.Add(this.grpFiltros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGestionGastos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion de Gastos";
            this.Load += new System.EventHandler(this.frmGestGastos_Load);
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            this.grpFechasFiltro.ResumeLayout(false);
            this.grpFechasFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTipodeGasto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVehiculos)).EndInit();
            this.grpGastos.ResumeLayout(false);
            this.grpGastos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGastos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.DateTimePicker dtpFechaDesdeFiltro;
        private System.Windows.Forms.TextBox txtMontoFiltro;
        private System.Windows.Forms.TextBox txtDescripcionFiltro;
        private System.Windows.Forms.ComboBox cbxEstadoFiltro;
        private System.Windows.Forms.ComboBox cbxTipoGastoFiltro;
        private System.Windows.Forms.ComboBox cbxVehiculoFiltro;
        private System.Windows.Forms.DateTimePicker dtpFechaHastaFiltro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox grpGastos;
        private System.Windows.Forms.GroupBox grpFechasFiltro;
        private System.Windows.Forms.CheckBox chkFechasFiltro;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.BindingSource bdsGastos;
        private System.Windows.Forms.BindingSource bdsTipodeGasto;
        private System.Windows.Forms.BindingSource bdsVehiculos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtIdFiltro;
        private System.Windows.Forms.Label lblSinResultados;
        private System.Windows.Forms.DataGridView grillaVehiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoGasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVencimientoDataGridViewTextBoxColumn;
    }
}