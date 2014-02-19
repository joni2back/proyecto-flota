namespace Vista.SistFlota
{
    partial class frmGasto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGasto));
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
            this.bdsTipodeGasto = new System.Windows.Forms.BindingSource(this.components);
            this.cbxVehiculo = new System.Windows.Forms.ComboBox();
            this.bdsVehiculos = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grpDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTipodeGasto)).BeginInit();
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
            this.grpDetalle.Location = new System.Drawing.Point(12, 11);
            this.grpDetalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDetalle.Name = "grpDetalle";
            this.grpDetalle.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDetalle.Size = new System.Drawing.Size(783, 177);
            this.grpDetalle.TabIndex = 3;
            this.grpDetalle.TabStop = false;
            this.grpDetalle.Text = "Detalle del Gasto";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(153, 25);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 1;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(81, 28);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(68, 21);
            this.lblNumero.TabIndex = 28;
            this.lblNumero.Text = "Numero";
            // 
            // dtpFechaVencimientoPago
            // 
            this.dtpFechaVencimientoPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimientoPago.Location = new System.Drawing.Point(189, 94);
            this.dtpFechaVencimientoPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaVencimientoPago.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.dtpFechaVencimientoPago.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaVencimientoPago.Name = "dtpFechaVencimientoPago";
            this.dtpFechaVencimientoPago.Size = new System.Drawing.Size(119, 22);
            this.dtpFechaVencimientoPago.TabIndex = 6;
            this.dtpFechaVencimientoPago.Value = new System.DateTime(2012, 6, 4, 0, 0, 0, 0);
            // 
            // lblFechaPV
            // 
            this.lblFechaPV.AutoSize = true;
            this.lblFechaPV.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPV.Location = new System.Drawing.Point(39, 97);
            this.lblFechaPV.Name = "lblFechaPV";
            this.lblFechaPV.Size = new System.Drawing.Size(144, 21);
            this.lblFechaPV.TabIndex = 26;
            this.lblFechaPV.Text = "Fecha Vencimiento";
            // 
            // lblHoraEmision
            // 
            this.lblHoraEmision.AutoSize = true;
            this.lblHoraEmision.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraEmision.Location = new System.Drawing.Point(335, 137);
            this.lblHoraEmision.Name = "lblHoraEmision";
            this.lblHoraEmision.Size = new System.Drawing.Size(126, 21);
            this.lblHoraEmision.TabIndex = 25;
            this.lblHoraEmision.Text = "Hora de emision";
            this.lblHoraEmision.Visible = false;
            // 
            // dtpHoraEmision
            // 
            this.dtpHoraEmision.CustomFormat = "";
            this.dtpHoraEmision.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraEmision.Location = new System.Drawing.Point(467, 134);
            this.dtpHoraEmision.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpHoraEmision.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.dtpHoraEmision.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpHoraEmision.Name = "dtpHoraEmision";
            this.dtpHoraEmision.ShowUpDown = true;
            this.dtpHoraEmision.Size = new System.Drawing.Size(119, 22);
            this.dtpHoraEmision.TabIndex = 9;
            this.dtpHoraEmision.Value = new System.DateTime(2012, 6, 4, 0, 0, 0, 0);
            this.dtpHoraEmision.Visible = false;
            // 
            // lblFechaEmision
            // 
            this.lblFechaEmision.AutoSize = true;
            this.lblFechaEmision.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEmision.Location = new System.Drawing.Point(53, 138);
            this.lblFechaEmision.Name = "lblFechaEmision";
            this.lblFechaEmision.Size = new System.Drawing.Size(133, 21);
            this.lblFechaEmision.TabIndex = 19;
            this.lblFechaEmision.Text = "Fecha de emisión";
            this.lblFechaEmision.Visible = false;
            // 
            // dtpFechaEmision
            // 
            this.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEmision.Location = new System.Drawing.Point(189, 135);
            this.dtpFechaEmision.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaEmision.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.dtpFechaEmision.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.Size = new System.Drawing.Size(119, 22);
            this.dtpFechaEmision.TabIndex = 8;
            this.dtpFechaEmision.Value = new System.DateTime(2012, 6, 4, 0, 0, 0, 0);
            this.dtpFechaEmision.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(548, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 21);
            this.label8.TabIndex = 22;
            this.label8.Text = "Monto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(57, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "Descripción";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(331, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 21);
            this.label10.TabIndex = 20;
            this.label10.Text = "Estado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(497, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 21);
            this.label11.TabIndex = 19;
            this.label11.Text = "Tipo de Gasto";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(281, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 21);
            this.label12.TabIndex = 18;
            this.label12.Text = "Vehículo";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(608, 60);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMonto.MaxLength = 7;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(119, 22);
            this.txtMonto.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(152, 60);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(380, 22);
            this.txtDescripcion.TabIndex = 4;
            // 
            // cbxEstado
            // 
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(389, 92);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(119, 24);
            this.cbxEstado.TabIndex = 7;
            this.cbxEstado.SelectedValueChanged += new System.EventHandler(this.cbxEstado_SelectedValueChanged);
            // 
            // cbxTipoGasto
            // 
            this.cbxTipoGasto.DataSource = this.bdsTipodeGasto;
            this.cbxTipoGasto.DisplayMember = "Descripcion";
            this.cbxTipoGasto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoGasto.FormattingEnabled = true;
            this.cbxTipoGasto.Location = new System.Drawing.Point(607, 22);
            this.cbxTipoGasto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxTipoGasto.Name = "cbxTipoGasto";
            this.cbxTipoGasto.Size = new System.Drawing.Size(119, 24);
            this.cbxTipoGasto.TabIndex = 3;
            this.cbxTipoGasto.SelectedValueChanged += new System.EventHandler(this.cbxTipoGasto_SelectedValueChanged);
            // 
            // bdsTipodeGasto
            // 
            this.bdsTipodeGasto.DataSource = typeof(Modelo.TipodeGasto);
            // 
            // cbxVehiculo
            // 
            this.cbxVehiculo.DataSource = this.bdsVehiculos;
            this.cbxVehiculo.DisplayMember = "Patente";
            this.cbxVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVehiculo.FormattingEnabled = true;
            this.cbxVehiculo.Location = new System.Drawing.Point(356, 23);
            this.cbxVehiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxVehiculo.Name = "cbxVehiculo";
            this.cbxVehiculo.Size = new System.Drawing.Size(119, 24);
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
            this.btnCancelar.Location = new System.Drawing.Point(671, 204);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 52);
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
            this.btnGuardar.Location = new System.Drawing.Point(524, 204);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(132, 52);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 268);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grpDetalle);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGasto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Datos Gasto";
            this.Load += new System.EventHandler(this.frmGasto_Load);
            this.grpDetalle.ResumeLayout(false);
            this.grpDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTipodeGasto)).EndInit();
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
        private System.Windows.Forms.BindingSource bdsTipodeGasto;
    }
}