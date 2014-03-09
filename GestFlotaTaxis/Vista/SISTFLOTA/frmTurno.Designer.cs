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
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.dtpFechaVencimientoPago = new System.Windows.Forms.DateTimePicker();
            this.lblFechaPV = new System.Windows.Forms.Label();
            this.lblHoraEmision = new System.Windows.Forms.Label();
            this.dtpHoraEmision = new System.Windows.Forms.DateTimePicker();
            this.lblFechaEmision = new System.Windows.Forms.Label();
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.cbxTipoGasto = new System.Windows.Forms.ComboBox();
            this.bdsChoferes = new System.Windows.Forms.BindingSource(this.components);
            this.cbxVehiculo = new System.Windows.Forms.ComboBox();
            this.bdsVehiculos = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grpDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChoferes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDetalle
            // 
            this.grpDetalle.Controls.Add(this.txtId);
            this.grpDetalle.Controls.Add(this.lblNumero);
            this.grpDetalle.Controls.Add(this.dtpFechaVencimientoPago);
            this.grpDetalle.Controls.Add(this.lblFechaPV);
            this.grpDetalle.Controls.Add(this.lblHoraEmision);
            this.grpDetalle.Controls.Add(this.dtpHoraEmision);
            this.grpDetalle.Controls.Add(this.lblFechaEmision);
            this.grpDetalle.Controls.Add(this.dtpFechaEmision);
            this.grpDetalle.Controls.Add(this.label8);
            this.grpDetalle.Controls.Add(this.label9);
            this.grpDetalle.Controls.Add(this.label10);
            this.grpDetalle.Controls.Add(this.label11);
            this.grpDetalle.Controls.Add(this.label12);
            this.grpDetalle.Controls.Add(this.txtMonto);
            this.grpDetalle.Controls.Add(this.txtDescripcion);
            this.grpDetalle.Controls.Add(this.cbxEstado);
            this.grpDetalle.Controls.Add(this.cbxTipoGasto);
            this.grpDetalle.Controls.Add(this.cbxVehiculo);
            this.grpDetalle.Location = new System.Drawing.Point(9, 9);
            this.grpDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.grpDetalle.Name = "grpDetalle";
            this.grpDetalle.Padding = new System.Windows.Forms.Padding(2);
            this.grpDetalle.Size = new System.Drawing.Size(741, 347);
            this.grpDetalle.TabIndex = 3;
            this.grpDetalle.TabStop = false;
            this.grpDetalle.Text = "Detalle del Turno";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(115, 20);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(76, 20);
            this.txtId.TabIndex = 1;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(61, 23);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(53, 15);
            this.lblNumero.TabIndex = 28;
            this.lblNumero.Text = "Numero";
            // 
            // dtpFechaVencimientoPago
            // 
            this.dtpFechaVencimientoPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimientoPago.Location = new System.Drawing.Point(142, 76);
            this.dtpFechaVencimientoPago.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaVencimientoPago.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.dtpFechaVencimientoPago.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaVencimientoPago.Name = "dtpFechaVencimientoPago";
            this.dtpFechaVencimientoPago.Size = new System.Drawing.Size(90, 20);
            this.dtpFechaVencimientoPago.TabIndex = 6;
            this.dtpFechaVencimientoPago.Value = new System.DateTime(2012, 6, 4, 0, 0, 0, 0);
            // 
            // lblFechaPV
            // 
            this.lblFechaPV.AutoSize = true;
            this.lblFechaPV.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPV.Location = new System.Drawing.Point(29, 79);
            this.lblFechaPV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaPV.Name = "lblFechaPV";
            this.lblFechaPV.Size = new System.Drawing.Size(110, 15);
            this.lblFechaPV.TabIndex = 26;
            this.lblFechaPV.Text = "Fecha Vencimiento";
            // 
            // lblHoraEmision
            // 
            this.lblHoraEmision.AutoSize = true;
            this.lblHoraEmision.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraEmision.Location = new System.Drawing.Point(251, 111);
            this.lblHoraEmision.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoraEmision.Name = "lblHoraEmision";
            this.lblHoraEmision.Size = new System.Drawing.Size(96, 15);
            this.lblHoraEmision.TabIndex = 25;
            this.lblHoraEmision.Text = "Hora de emision";
            this.lblHoraEmision.Visible = false;
            // 
            // dtpHoraEmision
            // 
            this.dtpHoraEmision.CustomFormat = "";
            this.dtpHoraEmision.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraEmision.Location = new System.Drawing.Point(350, 109);
            this.dtpHoraEmision.Margin = new System.Windows.Forms.Padding(2);
            this.dtpHoraEmision.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.dtpHoraEmision.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpHoraEmision.Name = "dtpHoraEmision";
            this.dtpHoraEmision.ShowUpDown = true;
            this.dtpHoraEmision.Size = new System.Drawing.Size(90, 20);
            this.dtpHoraEmision.TabIndex = 9;
            this.dtpHoraEmision.Value = new System.DateTime(2012, 6, 4, 0, 0, 0, 0);
            this.dtpHoraEmision.Visible = false;
            // 
            // lblFechaEmision
            // 
            this.lblFechaEmision.AutoSize = true;
            this.lblFechaEmision.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEmision.Location = new System.Drawing.Point(40, 112);
            this.lblFechaEmision.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaEmision.Name = "lblFechaEmision";
            this.lblFechaEmision.Size = new System.Drawing.Size(101, 15);
            this.lblFechaEmision.TabIndex = 19;
            this.lblFechaEmision.Text = "Fecha de emisión";
            this.lblFechaEmision.Visible = false;
            // 
            // dtpFechaEmision
            // 
            this.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEmision.Location = new System.Drawing.Point(142, 110);
            this.dtpFechaEmision.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaEmision.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.dtpFechaEmision.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.Size = new System.Drawing.Size(90, 20);
            this.dtpFechaEmision.TabIndex = 8;
            this.dtpFechaEmision.Value = new System.DateTime(2012, 6, 4, 0, 0, 0, 0);
            this.dtpFechaEmision.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(411, 51);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Monto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(43, 51);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Descripción";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(248, 78);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Estado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(396, 20);
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
            this.label12.Location = new System.Drawing.Point(211, 22);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "Vehículo";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(456, 49);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(2);
            this.txtMonto.MaxLength = 7;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(90, 20);
            this.txtMonto.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(114, 49);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(286, 20);
            this.txtDescripcion.TabIndex = 4;
            // 
            // cbxEstado
            // 
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(292, 75);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(90, 21);
            this.cbxEstado.TabIndex = 7;
            this.cbxEstado.SelectedValueChanged += new System.EventHandler(this.cbxEstado_SelectedValueChanged);
            // 
            // cbxTipoGasto
            // 
            this.cbxTipoGasto.DataSource = this.bdsChoferes;
            this.cbxTipoGasto.DisplayMember = "Nombre";
            this.cbxTipoGasto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoGasto.FormattingEnabled = true;
            this.cbxTipoGasto.Location = new System.Drawing.Point(444, 18);
            this.cbxTipoGasto.Margin = new System.Windows.Forms.Padding(2);
            this.cbxTipoGasto.Name = "cbxTipoGasto";
            this.cbxTipoGasto.Size = new System.Drawing.Size(90, 21);
            this.cbxTipoGasto.TabIndex = 3;
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
            this.cbxVehiculo.Location = new System.Drawing.Point(267, 19);
            this.cbxVehiculo.Margin = new System.Windows.Forms.Padding(2);
            this.cbxVehiculo.Name = "cbxVehiculo";
            this.cbxVehiculo.Size = new System.Drawing.Size(90, 21);
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
            this.btnCancelar.Location = new System.Drawing.Point(651, 360);
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
            this.btnGuardar.Location = new System.Drawing.Point(541, 360);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 42);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 413);
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
            ((System.ComponentModel.ISupportInitialize)(this.bdsChoferes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVehiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDetalle;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimientoPago;
        private System.Windows.Forms.Label lblFechaPV;
        private System.Windows.Forms.Label lblHoraEmision;
        private System.Windows.Forms.DateTimePicker dtpHoraEmision;
        private System.Windows.Forms.Label lblFechaEmision;
        private System.Windows.Forms.DateTimePicker dtpFechaEmision;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.ComboBox cbxTipoGasto;
        private System.Windows.Forms.ComboBox cbxVehiculo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.BindingSource bdsVehiculos;
        private System.Windows.Forms.BindingSource bdsChoferes;
    }
}