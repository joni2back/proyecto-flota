namespace Vista.SistFlota
{
    partial class frmMonitorGastos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonitorGastos));
            this.label1 = new System.Windows.Forms.Label();
            this.grillaVehiculos = new System.Windows.Forms.DataGridView();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVencimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsGastos = new System.Windows.Forms.BindingSource(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.txtFechaVencimiento = new System.Windows.Forms.TextBox();
            this.txtTipodeGasto = new System.Windows.Forms.TextBox();
            this.txtVehiculo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.ImgRojo = new System.Windows.Forms.PictureBox();
            this.ImgAmarillo = new System.Windows.Forms.PictureBox();
            this.ImgVerde = new System.Windows.Forms.PictureBox();
            this.ImgVacio = new System.Windows.Forms.PictureBox();
            this.lblSinResultados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgRojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgAmarillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgVacio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monitor de Gastos";
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
            this.descripcionDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.fechaVencimientoDataGridViewTextBoxColumn});
            this.grillaVehiculos.DataSource = this.bdsGastos;
            this.grillaVehiculos.Location = new System.Drawing.Point(20, 46);
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
            this.grillaVehiculos.Size = new System.Drawing.Size(493, 284);
            this.grillaVehiculos.TabIndex = 1;
            this.grillaVehiculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaVehiculos_CellClick);
            this.grillaVehiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaVehiculos_CellContentClick);
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Frozen = true;
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.descripcionDataGridViewTextBoxColumn.Width = 270;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "Monto";
            this.montoDataGridViewTextBoxColumn.Frozen = true;
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.ReadOnly = true;
            this.montoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // fechaVencimientoDataGridViewTextBoxColumn
            // 
            this.fechaVencimientoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fechaVencimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaVencimiento";
            this.fechaVencimientoDataGridViewTextBoxColumn.Frozen = true;
            this.fechaVencimientoDataGridViewTextBoxColumn.HeaderText = "Vencimiento";
            this.fechaVencimientoDataGridViewTextBoxColumn.Name = "fechaVencimientoDataGridViewTextBoxColumn";
            this.fechaVencimientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaVencimientoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fechaVencimientoDataGridViewTextBoxColumn.Width = 120;
            // 
            // bdsGastos
            // 
            this.bdsGastos.DataSource = typeof(Modelo.Gasto);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(423, 568);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 42);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Enabled = false;
            this.btnPagar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Image = ((System.Drawing.Image)(resources.GetObject("btnPagar.Image")));
            this.btnPagar.Location = new System.Drawing.Point(110, 520);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(207, 90);
            this.btnPagar.TabIndex = 2;
            this.btnPagar.Text = "        Pagar";
            this.btnPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // txtFechaVencimiento
            // 
            this.txtFechaVencimiento.Enabled = false;
            this.txtFechaVencimiento.Location = new System.Drawing.Point(253, 485);
            this.txtFechaVencimiento.Margin = new System.Windows.Forms.Padding(2);
            this.txtFechaVencimiento.Name = "txtFechaVencimiento";
            this.txtFechaVencimiento.Size = new System.Drawing.Size(92, 20);
            this.txtFechaVencimiento.TabIndex = 56;
            // 
            // txtTipodeGasto
            // 
            this.txtTipodeGasto.Enabled = false;
            this.txtTipodeGasto.Location = new System.Drawing.Point(253, 358);
            this.txtTipodeGasto.Margin = new System.Windows.Forms.Padding(2);
            this.txtTipodeGasto.Name = "txtTipodeGasto";
            this.txtTipodeGasto.Size = new System.Drawing.Size(92, 20);
            this.txtTipodeGasto.TabIndex = 55;
            // 
            // txtVehiculo
            // 
            this.txtVehiculo.Enabled = false;
            this.txtVehiculo.Location = new System.Drawing.Point(100, 358);
            this.txtVehiculo.Margin = new System.Windows.Forms.Padding(2);
            this.txtVehiculo.Name = "txtVehiculo";
            this.txtVehiculo.Size = new System.Drawing.Size(61, 20);
            this.txtVehiculo.TabIndex = 54;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Enabled = false;
            this.label15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(140, 488);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 15);
            this.label15.TabIndex = 53;
            this.label15.Text = "Fecha Vencimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(366, 360);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 52;
            this.label8.Text = "Monto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 412);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 15);
            this.label9.TabIndex = 51;
            this.label9.Text = "Descripción";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(170, 360);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 15);
            this.label11.TabIndex = 50;
            this.label11.Text = "Tipo de Gasto";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Enabled = false;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(44, 360);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 15);
            this.label12.TabIndex = 49;
            this.label12.Text = "Vehículo";
            // 
            // txtMonto
            // 
            this.txtMonto.Enabled = false;
            this.txtMonto.Location = new System.Drawing.Point(413, 358);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(2);
            this.txtMonto.MaxLength = 7;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(78, 20);
            this.txtMonto.TabIndex = 48;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(99, 409);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(246, 50);
            this.txtDescripcion.TabIndex = 47;
            // 
            // ImgRojo
            // 
            this.ImgRojo.Image = ((System.Drawing.Image)(resources.GetObject("ImgRojo.Image")));
            this.ImgRojo.Location = new System.Drawing.Point(377, 400);
            this.ImgRojo.Margin = new System.Windows.Forms.Padding(2);
            this.ImgRojo.Name = "ImgRojo";
            this.ImgRojo.Size = new System.Drawing.Size(136, 162);
            this.ImgRojo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgRojo.TabIndex = 58;
            this.ImgRojo.TabStop = false;
            // 
            // ImgAmarillo
            // 
            this.ImgAmarillo.Image = ((System.Drawing.Image)(resources.GetObject("ImgAmarillo.Image")));
            this.ImgAmarillo.Location = new System.Drawing.Point(377, 400);
            this.ImgAmarillo.Margin = new System.Windows.Forms.Padding(2);
            this.ImgAmarillo.Name = "ImgAmarillo";
            this.ImgAmarillo.Size = new System.Drawing.Size(136, 162);
            this.ImgAmarillo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgAmarillo.TabIndex = 59;
            this.ImgAmarillo.TabStop = false;
            // 
            // ImgVerde
            // 
            this.ImgVerde.Image = ((System.Drawing.Image)(resources.GetObject("ImgVerde.Image")));
            this.ImgVerde.Location = new System.Drawing.Point(377, 400);
            this.ImgVerde.Margin = new System.Windows.Forms.Padding(2);
            this.ImgVerde.Name = "ImgVerde";
            this.ImgVerde.Size = new System.Drawing.Size(136, 162);
            this.ImgVerde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgVerde.TabIndex = 60;
            this.ImgVerde.TabStop = false;
            // 
            // ImgVacio
            // 
            this.ImgVacio.Image = ((System.Drawing.Image)(resources.GetObject("ImgVacio.Image")));
            this.ImgVacio.Location = new System.Drawing.Point(377, 400);
            this.ImgVacio.Margin = new System.Windows.Forms.Padding(2);
            this.ImgVacio.Name = "ImgVacio";
            this.ImgVacio.Size = new System.Drawing.Size(136, 162);
            this.ImgVacio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgVacio.TabIndex = 61;
            this.ImgVacio.TabStop = false;
            // 
            // lblSinResultados
            // 
            this.lblSinResultados.AutoSize = true;
            this.lblSinResultados.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblSinResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinResultados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSinResultados.Location = new System.Drawing.Point(200, 74);
            this.lblSinResultados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSinResultados.Name = "lblSinResultados";
            this.lblSinResultados.Size = new System.Drawing.Size(129, 13);
            this.lblSinResultados.TabIndex = 62;
            this.lblSinResultados.Text = "No hay gastos por vencer";
            this.lblSinResultados.Visible = false;
            // 
            // frmMonitorGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 621);
            this.Controls.Add(this.lblSinResultados);
            this.Controls.Add(this.ImgVacio);
            this.Controls.Add(this.ImgVerde);
            this.Controls.Add(this.ImgAmarillo);
            this.Controls.Add(this.ImgRojo);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.txtFechaVencimiento);
            this.Controls.Add(this.txtTipodeGasto);
            this.Controls.Add(this.txtVehiculo);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grillaVehiculos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMonitorGastos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Monitor de Gastos";
            this.Load += new System.EventHandler(this.frmMonitorGastos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgRojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgAmarillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgVacio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grillaVehiculos;
        private System.Windows.Forms.BindingSource bdsGastos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.TextBox txtFechaVencimiento;
        private System.Windows.Forms.TextBox txtTipodeGasto;
        private System.Windows.Forms.TextBox txtVehiculo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.PictureBox ImgRojo;
        private System.Windows.Forms.PictureBox ImgAmarillo;
        private System.Windows.Forms.PictureBox ImgVerde;
        private System.Windows.Forms.PictureBox ImgVacio;
        private System.Windows.Forms.Label lblSinResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVencimientoDataGridViewTextBoxColumn;
    }
}