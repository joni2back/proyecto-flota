namespace Vista.SistFlota
{
    partial class frmInforme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInforme));
            this.btnSalir = new System.Windows.Forms.Button();
            this.bdsInforme = new System.Windows.Forms.BindingSource(this.components);
            this.btnVehiculosGastos = new System.Windows.Forms.Button();
            this.btnVehiculosActivos = new System.Windows.Forms.Button();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaHastaFiltro = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesdeFiltro = new System.Windows.Forms.DateTimePicker();
            this.rdbVehiculos = new System.Windows.Forms.RadioButton();
            this.rdbChoferes = new System.Windows.Forms.RadioButton();
            this.rdbTurno = new System.Windows.Forms.RadioButton();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bdsInforme)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(688, 16);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 42);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // bdsInforme
            // 
            this.bdsInforme.DataSource = typeof(Modelo.Vehiculo);
            this.bdsInforme.Sort = "Patente";
            // 
            // btnVehiculosGastos
            // 
            this.btnVehiculosGastos.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehiculosGastos.Image = ((System.Drawing.Image)(resources.GetObject("btnVehiculosGastos.Image")));
            this.btnVehiculosGastos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehiculosGastos.Location = new System.Drawing.Point(124, 16);
            this.btnVehiculosGastos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVehiculosGastos.Name = "btnVehiculosGastos";
            this.btnVehiculosGastos.Size = new System.Drawing.Size(350, 42);
            this.btnVehiculosGastos.TabIndex = 1;
            this.btnVehiculosGastos.Text = "Generar Informe de Gastos totales por Vehiculos";
            this.btnVehiculosGastos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVehiculosGastos.UseVisualStyleBackColor = true;
            this.btnVehiculosGastos.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnVehiculosActivos
            // 
            this.btnVehiculosActivos.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehiculosActivos.Image = ((System.Drawing.Image)(resources.GetObject("btnVehiculosActivos.Image")));
            this.btnVehiculosActivos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehiculosActivos.Location = new System.Drawing.Point(124, 75);
            this.btnVehiculosActivos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVehiculosActivos.Name = "btnVehiculosActivos";
            this.btnVehiculosActivos.Size = new System.Drawing.Size(350, 42);
            this.btnVehiculosActivos.TabIndex = 2;
            this.btnVehiculosActivos.Text = "Generar Informe de Vehículos activos";
            this.btnVehiculosActivos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVehiculosActivos.UseVisualStyleBackColor = true;
            this.btnVehiculosActivos.Click += new System.EventHandler(this.btnVehiculosActivos_Click);
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "PDF"});
            this.cbTipo.Location = new System.Drawing.Point(9, 39);
            this.cbTipo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(92, 21);
            this.cbTipo.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Formato:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbFiltro);
            this.groupBox1.Controls.Add(this.rdbTurno);
            this.groupBox1.Controls.Add(this.rdbChoferes);
            this.groupBox1.Controls.Add(this.rdbVehiculos);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpFechaHastaFiltro);
            this.groupBox1.Controls.Add(this.dtpFechaDesdeFiltro);
            this.groupBox1.Location = new System.Drawing.Point(72, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 129);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informe Turnos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Hasta";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Desde";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dtpFechaHastaFiltro
            // 
            this.dtpFechaHastaFiltro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHastaFiltro.Location = new System.Drawing.Point(94, 63);
            this.dtpFechaHastaFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaHastaFiltro.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.dtpFechaHastaFiltro.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaHastaFiltro.Name = "dtpFechaHastaFiltro";
            this.dtpFechaHastaFiltro.Size = new System.Drawing.Size(90, 20);
            this.dtpFechaHastaFiltro.TabIndex = 15;
            this.dtpFechaHastaFiltro.Value = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.dtpFechaHastaFiltro.ValueChanged += new System.EventHandler(this.dtpFechaHastaFiltro_ValueChanged);
            // 
            // dtpFechaDesdeFiltro
            // 
            this.dtpFechaDesdeFiltro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesdeFiltro.Location = new System.Drawing.Point(94, 32);
            this.dtpFechaDesdeFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaDesdeFiltro.MaxDate = new System.DateTime(2998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaDesdeFiltro.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaDesdeFiltro.Name = "dtpFechaDesdeFiltro";
            this.dtpFechaDesdeFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpFechaDesdeFiltro.Size = new System.Drawing.Size(90, 20);
            this.dtpFechaDesdeFiltro.TabIndex = 14;
            this.dtpFechaDesdeFiltro.Value = new System.DateTime(2012, 6, 4, 0, 0, 0, 0);
            this.dtpFechaDesdeFiltro.ValueChanged += new System.EventHandler(this.dtpFechaDesdeFiltro_ValueChanged);
            // 
            // rdbVehiculos
            // 
            this.rdbVehiculos.AutoSize = true;
            this.rdbVehiculos.Location = new System.Drawing.Point(271, 30);
            this.rdbVehiculos.Name = "rdbVehiculos";
            this.rdbVehiculos.Size = new System.Drawing.Size(71, 17);
            this.rdbVehiculos.TabIndex = 18;
            this.rdbVehiculos.TabStop = true;
            this.rdbVehiculos.Text = "Vehiculos";
            this.rdbVehiculos.UseVisualStyleBackColor = true;
            // 
            // rdbChoferes
            // 
            this.rdbChoferes.AutoSize = true;
            this.rdbChoferes.Location = new System.Drawing.Point(271, 52);
            this.rdbChoferes.Name = "rdbChoferes";
            this.rdbChoferes.Size = new System.Drawing.Size(67, 17);
            this.rdbChoferes.TabIndex = 19;
            this.rdbChoferes.TabStop = true;
            this.rdbChoferes.Text = "Choferes";
            this.rdbChoferes.UseVisualStyleBackColor = true;
            // 
            // rdbTurno
            // 
            this.rdbTurno.AutoSize = true;
            this.rdbTurno.Location = new System.Drawing.Point(271, 75);
            this.rdbTurno.Name = "rdbTurno";
            this.rdbTurno.Size = new System.Drawing.Size(77, 17);
            this.rdbTurno.TabIndex = 20;
            this.rdbTurno.TabStop = true;
            this.rdbTurno.Text = "Tipo Turno";
            this.rdbTurno.UseVisualStyleBackColor = true;
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Location = new System.Drawing.Point(413, 35);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltro.TabIndex = 21;
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(124, 319);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 42);
            this.button1.TabIndex = 36;
            this.button1.Text = "Generar Informe Turnos";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 421);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.btnVehiculosActivos);
            this.Controls.Add(this.btnVehiculosGastos);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInforme";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Informes";
            this.Load += new System.EventHandler(this.frmInforme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsInforme)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.BindingSource bdsInforme;
        private System.Windows.Forms.Button btnVehiculosGastos;
        private System.Windows.Forms.Button btnVehiculosActivos;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaHastaFiltro;
        private System.Windows.Forms.DateTimePicker dtpFechaDesdeFiltro;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.RadioButton rdbTurno;
        private System.Windows.Forms.RadioButton rdbChoferes;
        private System.Windows.Forms.RadioButton rdbVehiculos;
        private System.Windows.Forms.Button button1;
    }
}