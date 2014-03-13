namespace Vista.SistFlota
{
    partial class frmTurno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTurno));
            this.grpDetalle = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.gbxGastos = new System.Windows.Forms.GroupBox();
            this.grillaGastos = new System.Windows.Forms.DataGridView();
            this.cbxSelecTodosGastos = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnEliminarGasto = new System.Windows.Forms.Button();
            this.btnAgregarGasto = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtViajesRealizados = new System.Windows.Forms.TextBox();
            this.gbxCuentasCorrientes = new System.Windows.Forms.GroupBox();
            this.grillaCuentasCorrientes = new System.Windows.Forms.DataGridView();
            this.cbxSelecTodosCC = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminarCC = new System.Windows.Forms.Button();
            this.btnAgregarCC = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHorasTrabajadas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRecaudacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKmOcupados = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtKmRecorridos = new System.Windows.Forms.TextBox();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.cbxChofer = new System.Windows.Forms.ComboBox();
            this.bdsChoferes = new System.Windows.Forms.BindingSource(this.components);
            this.cbxVehiculo = new System.Windows.Forms.ComboBox();
            this.bdsVehiculos = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.bdsCuentasCorrientes = new System.Windows.Forms.BindingSource(this.components);
            this.dbsGatos = new System.Windows.Forms.BindingSource(this.components);
            this.grpDetalle.SuspendLayout();
            this.gbxGastos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaGastos)).BeginInit();
            this.gbxCuentasCorrientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCuentasCorrientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChoferes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCuentasCorrientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsGatos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDetalle
            // 
            this.grpDetalle.Controls.Add(this.dateTimePicker1);
            this.grpDetalle.Controls.Add(this.label1);
            this.grpDetalle.Controls.Add(this.label16);
            this.grpDetalle.Controls.Add(this.textBox4);
            this.grpDetalle.Controls.Add(this.label15);
            this.grpDetalle.Controls.Add(this.textBox3);
            this.grpDetalle.Controls.Add(this.gbxGastos);
            this.grpDetalle.Controls.Add(this.label13);
            this.grpDetalle.Controls.Add(this.textBox2);
            this.grpDetalle.Controls.Add(this.label7);
            this.grpDetalle.Controls.Add(this.textBox1);
            this.grpDetalle.Controls.Add(this.label6);
            this.grpDetalle.Controls.Add(this.txtViajesRealizados);
            this.grpDetalle.Controls.Add(this.gbxCuentasCorrientes);
            this.grpDetalle.Controls.Add(this.label4);
            this.grpDetalle.Controls.Add(this.txtHorasTrabajadas);
            this.grpDetalle.Controls.Add(this.label3);
            this.grpDetalle.Controls.Add(this.txtRecaudacion);
            this.grpDetalle.Controls.Add(this.label2);
            this.grpDetalle.Controls.Add(this.txtKmOcupados);
            this.grpDetalle.Controls.Add(this.txtId);
            this.grpDetalle.Controls.Add(this.lblNumero);
            this.grpDetalle.Controls.Add(this.dtpFecha);
            this.grpDetalle.Controls.Add(this.lblFecha);
            this.grpDetalle.Controls.Add(this.label8);
            this.grpDetalle.Controls.Add(this.label9);
            this.grpDetalle.Controls.Add(this.label11);
            this.grpDetalle.Controls.Add(this.label12);
            this.grpDetalle.Controls.Add(this.txtKmRecorridos);
            this.grpDetalle.Controls.Add(this.txtComentarios);
            this.grpDetalle.Controls.Add(this.cbxChofer);
            this.grpDetalle.Controls.Add(this.cbxVehiculo);
            this.grpDetalle.Location = new System.Drawing.Point(9, 35);
            this.grpDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.grpDetalle.Name = "grpDetalle";
            this.grpDetalle.Padding = new System.Windows.Forms.Padding(2);
            this.grpDetalle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpDetalle.Size = new System.Drawing.Size(969, 405);
            this.grpDetalle.TabIndex = 3;
            this.grpDetalle.TabStop = false;
            this.grpDetalle.Text = "Detalle del Turno";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(412, 51);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(90, 20);
            this.dateTimePicker1.TabIndex = 50;
            this.dateTimePicker1.Value = new System.DateTime(2012, 6, 4, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 51;
            this.label1.Text = "Fecha de fin";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(660, 369);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(153, 23);
            this.label16.TabIndex = 49;
            this.label16.Text = "Recaudacion Neta";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(817, 365);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.MaxLength = 7;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(123, 29);
            this.textBox4.TabIndex = 48;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(774, 91);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 15);
            this.label15.TabIndex = 47;
            this.label15.Text = "Total Gastos";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(850, 89);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.MaxLength = 7;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(90, 20);
            this.textBox3.TabIndex = 46;
            // 
            // gbxGastos
            // 
            this.gbxGastos.Controls.Add(this.grillaGastos);
            this.gbxGastos.Controls.Add(this.cbxSelecTodosGastos);
            this.gbxGastos.Controls.Add(this.label14);
            this.gbxGastos.Controls.Add(this.btnEliminarGasto);
            this.gbxGastos.Controls.Add(this.btnAgregarGasto);
            this.gbxGastos.Location = new System.Drawing.Point(496, 129);
            this.gbxGastos.Name = "gbxGastos";
            this.gbxGastos.Size = new System.Drawing.Size(455, 191);
            this.gbxGastos.TabIndex = 45;
            this.gbxGastos.TabStop = false;
            this.gbxGastos.Text = "Gastos";
            // 
            // grillaGastos
            // 
            this.grillaGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaGastos.Location = new System.Drawing.Point(15, 21);
            this.grillaGastos.Name = "grillaGastos";
            this.grillaGastos.Size = new System.Drawing.Size(308, 139);
            this.grillaGastos.TabIndex = 40;
            // 
            // cbxSelecTodosGastos
            // 
            this.cbxSelecTodosGastos.AutoSize = true;
            this.cbxSelecTodosGastos.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelecTodosGastos.Location = new System.Drawing.Point(15, 164);
            this.cbxSelecTodosGastos.Name = "cbxSelecTodosGastos";
            this.cbxSelecTodosGastos.Size = new System.Drawing.Size(110, 17);
            this.cbxSelecTodosGastos.TabIndex = 39;
            this.cbxSelecTodosGastos.Text = "Seleccionar Todos";
            this.cbxSelecTodosGastos.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(263, 163);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "Cantidad: X";
            // 
            // btnEliminarGasto
            // 
            this.btnEliminarGasto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarGasto.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarGasto.Image")));
            this.btnEliminarGasto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarGasto.Location = new System.Drawing.Point(336, 106);
            this.btnEliminarGasto.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarGasto.Name = "btnEliminarGasto";
            this.btnEliminarGasto.Size = new System.Drawing.Size(103, 55);
            this.btnEliminarGasto.TabIndex = 37;
            this.btnEliminarGasto.Text = "Eliminar\r\nGasto";
            this.btnEliminarGasto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarGasto.UseVisualStyleBackColor = true;
            // 
            // btnAgregarGasto
            // 
            this.btnAgregarGasto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAgregarGasto.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarGasto.Image")));
            this.btnAgregarGasto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarGasto.Location = new System.Drawing.Point(336, 27);
            this.btnAgregarGasto.Name = "btnAgregarGasto";
            this.btnAgregarGasto.Size = new System.Drawing.Size(103, 74);
            this.btnAgregarGasto.TabIndex = 29;
            this.btnAgregarGasto.Text = "Agregar\r\nGasto";
            this.btnAgregarGasto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarGasto.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(661, 330);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 23);
            this.label13.TabIndex = 44;
            this.label13.Text = "Recaudacion Total";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(817, 330);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.MaxLength = 7;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 29);
            this.textBox2.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(734, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 30);
            this.label7.TabIndex = 42;
            this.label7.Text = "Recaudacion\r\nCuentas Corrientes";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(850, 55);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.MaxLength = 7;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 20);
            this.textBox1.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(556, 83);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 30);
            this.label6.TabIndex = 40;
            this.label6.Text = "Cantidad\r\nde viajes";
            // 
            // txtViajesRealizados
            // 
            this.txtViajesRealizados.Location = new System.Drawing.Point(620, 89);
            this.txtViajesRealizados.Margin = new System.Windows.Forms.Padding(2);
            this.txtViajesRealizados.MaxLength = 7;
            this.txtViajesRealizados.Name = "txtViajesRealizados";
            this.txtViajesRealizados.Size = new System.Drawing.Size(90, 20);
            this.txtViajesRealizados.TabIndex = 39;
            // 
            // gbxCuentasCorrientes
            // 
            this.gbxCuentasCorrientes.Controls.Add(this.grillaCuentasCorrientes);
            this.gbxCuentasCorrientes.Controls.Add(this.cbxSelecTodosCC);
            this.gbxCuentasCorrientes.Controls.Add(this.label5);
            this.gbxCuentasCorrientes.Controls.Add(this.btnEliminarCC);
            this.gbxCuentasCorrientes.Controls.Add(this.btnAgregarCC);
            this.gbxCuentasCorrientes.Location = new System.Drawing.Point(23, 129);
            this.gbxCuentasCorrientes.Name = "gbxCuentasCorrientes";
            this.gbxCuentasCorrientes.Size = new System.Drawing.Size(455, 191);
            this.gbxCuentasCorrientes.TabIndex = 38;
            this.gbxCuentasCorrientes.TabStop = false;
            this.gbxCuentasCorrientes.Text = "Cuentas Corrientes";
            // 
            // grillaCuentasCorrientes
            // 
            this.grillaCuentasCorrientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaCuentasCorrientes.Location = new System.Drawing.Point(15, 21);
            this.grillaCuentasCorrientes.Name = "grillaCuentasCorrientes";
            this.grillaCuentasCorrientes.Size = new System.Drawing.Size(308, 139);
            this.grillaCuentasCorrientes.TabIndex = 41;
            // 
            // cbxSelecTodosCC
            // 
            this.cbxSelecTodosCC.AutoSize = true;
            this.cbxSelecTodosCC.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelecTodosCC.Location = new System.Drawing.Point(15, 164);
            this.cbxSelecTodosCC.Name = "cbxSelecTodosCC";
            this.cbxSelecTodosCC.Size = new System.Drawing.Size(110, 17);
            this.cbxSelecTodosCC.TabIndex = 39;
            this.cbxSelecTodosCC.Text = "Seleccionar Todos";
            this.cbxSelecTodosCC.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(263, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Cantidad: X";
            // 
            // btnEliminarCC
            // 
            this.btnEliminarCC.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCC.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarCC.Image")));
            this.btnEliminarCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarCC.Location = new System.Drawing.Point(336, 106);
            this.btnEliminarCC.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarCC.Name = "btnEliminarCC";
            this.btnEliminarCC.Size = new System.Drawing.Size(103, 55);
            this.btnEliminarCC.TabIndex = 37;
            this.btnEliminarCC.Text = "Eliminar\r\nCuenta\r\nCorriente";
            this.btnEliminarCC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarCC.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCC
            // 
            this.btnAgregarCC.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAgregarCC.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarCC.Image")));
            this.btnAgregarCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCC.Location = new System.Drawing.Point(336, 27);
            this.btnAgregarCC.Name = "btnAgregarCC";
            this.btnAgregarCC.Size = new System.Drawing.Size(103, 74);
            this.btnAgregarCC.TabIndex = 29;
            this.btnAgregarCC.Text = "Agregar\r\nCuenta\r\nCorriente";
            this.btnAgregarCC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarCC.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(318, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "Hora de inicio";
            // 
            // txtHorasTrabajadas
            // 
            this.txtHorasTrabajadas.Location = new System.Drawing.Point(412, 86);
            this.txtHorasTrabajadas.Margin = new System.Windows.Forms.Padding(2);
            this.txtHorasTrabajadas.MaxLength = 7;
            this.txtHorasTrabajadas.Name = "txtHorasTrabajadas";
            this.txtHorasTrabajadas.Size = new System.Drawing.Size(90, 20);
            this.txtHorasTrabajadas.TabIndex = 34;
            this.txtHorasTrabajadas.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(772, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 30);
            this.label3.TabIndex = 33;
            this.label3.Text = "Recaudacion\r\nen Efectivo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRecaudacion
            // 
            this.txtRecaudacion.Location = new System.Drawing.Point(850, 19);
            this.txtRecaudacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtRecaudacion.MaxLength = 7;
            this.txtRecaudacion.Name = "txtRecaudacion";
            this.txtRecaudacion.Size = new System.Drawing.Size(90, 20);
            this.txtRecaudacion.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(530, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Km Ocupados";
            // 
            // txtKmOcupados
            // 
            this.txtKmOcupados.Location = new System.Drawing.Point(620, 54);
            this.txtKmOcupados.Margin = new System.Windows.Forms.Padding(2);
            this.txtKmOcupados.MaxLength = 7;
            this.txtKmOcupados.Name = "txtKmOcupados";
            this.txtKmOcupados.Size = new System.Drawing.Size(90, 20);
            this.txtKmOcupados.TabIndex = 30;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(99, 19);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(157, 20);
            this.txtId.TabIndex = 1;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(42, 21);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(53, 15);
            this.lblNumero.TabIndex = 28;
            this.lblNumero.Text = "Numero";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(412, 21);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(90, 20);
            this.dtpFecha.TabIndex = 6;
            this.dtpFecha.Value = new System.DateTime(2012, 6, 4, 0, 0, 0, 0);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(316, 24);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(83, 15);
            this.lblFecha.TabIndex = 26;
            this.lblFecha.Text = "Fecha de incio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(525, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Km Recorridos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 332);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Comentarios";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(51, 56);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Chofer";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(42, 94);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "Vehículo";
            // 
            // txtKmRecorridos
            // 
            this.txtKmRecorridos.Location = new System.Drawing.Point(620, 19);
            this.txtKmRecorridos.Margin = new System.Windows.Forms.Padding(2);
            this.txtKmRecorridos.MaxLength = 7;
            this.txtKmRecorridos.Name = "txtKmRecorridos";
            this.txtKmRecorridos.Size = new System.Drawing.Size(90, 20);
            this.txtKmRecorridos.TabIndex = 5;
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(99, 330);
            this.txtComentarios.Margin = new System.Windows.Forms.Padding(2);
            this.txtComentarios.MaxLength = 50;
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(544, 62);
            this.txtComentarios.TabIndex = 4;
            // 
            // cbxChofer
            // 
            this.cbxChofer.DataSource = this.bdsChoferes;
            this.cbxChofer.DisplayMember = "Nombre";
            this.cbxChofer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChofer.FormattingEnabled = true;
            this.cbxChofer.Location = new System.Drawing.Point(99, 54);
            this.cbxChofer.Margin = new System.Windows.Forms.Padding(2);
            this.cbxChofer.Name = "cbxChofer";
            this.cbxChofer.Size = new System.Drawing.Size(157, 21);
            this.cbxChofer.TabIndex = 3;
            // 
            // bdsChoferes
            // 
            this.bdsChoferes.DataSource = typeof(Modelo.Chofer);
            // 
            // cbxVehiculo
            // 
            this.cbxVehiculo.DataSource = this.bdsVehiculos;
            this.cbxVehiculo.DisplayMember = "Patente";
            this.cbxVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVehiculo.FormattingEnabled = true;
            this.cbxVehiculo.Location = new System.Drawing.Point(99, 92);
            this.cbxVehiculo.Margin = new System.Windows.Forms.Padding(2);
            this.cbxVehiculo.Name = "cbxVehiculo";
            this.cbxVehiculo.Size = new System.Drawing.Size(157, 21);
            this.cbxVehiculo.TabIndex = 2;
            // 
            // bdsVehiculos
            // 
            this.bdsVehiculos.DataSource = typeof(Modelo.Vehiculo);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(879, 445);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 42);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(769, 445);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 42);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(364, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(302, 24);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "Agregar nuevo turno de trabajo";
            // 
            // bdsCuentasCorrientes
            // 
            this.bdsCuentasCorrientes.DataSource = typeof(Modelo.CuentaCorriente);
            // 
            // dbsGatos
            // 
            this.dbsGatos.DataSource = typeof(Modelo.Gasto);
            // 
            // frmTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 492);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grpDetalle);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTurno";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Datos Turno";
            this.grpDetalle.ResumeLayout(false);
            this.grpDetalle.PerformLayout();
            this.gbxGastos.ResumeLayout(false);
            this.gbxGastos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaGastos)).EndInit();
            this.gbxCuentasCorrientes.ResumeLayout(false);
            this.gbxCuentasCorrientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCuentasCorrientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChoferes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCuentasCorrientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsGatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDetalle;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtKmRecorridos;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.ComboBox cbxChofer;
        private System.Windows.Forms.ComboBox cbxVehiculo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.BindingSource bdsVehiculos;
        private System.Windows.Forms.BindingSource bdsChoferes;
        private System.Windows.Forms.Button btnAgregarCC;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRecaudacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKmOcupados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox gbxGastos;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnEliminarGasto;
        private System.Windows.Forms.Button btnAgregarGasto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtViajesRealizados;
        private System.Windows.Forms.GroupBox gbxCuentasCorrientes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEliminarCC;
        private System.Windows.Forms.DataGridView grillaGastos;
        private System.Windows.Forms.CheckBox cbxSelecTodosGastos;
        private System.Windows.Forms.DataGridView grillaCuentasCorrientes;
        private System.Windows.Forms.CheckBox cbxSelecTodosCC;
        private System.Windows.Forms.TextBox txtHorasTrabajadas;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bdsCuentasCorrientes;
        private System.Windows.Forms.BindingSource dbsGatos;
    }
}