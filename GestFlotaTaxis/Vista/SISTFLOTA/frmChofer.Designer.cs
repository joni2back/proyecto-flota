namespace Vista
{
    partial class frmChofer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChofer));
            this.grpDetalle = new System.Windows.Forms.GroupBox();
            this.checkActivo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKilometraje = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.MaskedTextBox();
            this.txtPatente = new System.Windows.Forms.MaskedTextBox();
            this.txtPatenteTaxi = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grpDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDetalle
            // 
            this.grpDetalle.Controls.Add(this.checkActivo);
            this.grpDetalle.Controls.Add(this.label1);
            this.grpDetalle.Controls.Add(this.txtKilometraje);
            this.grpDetalle.Controls.Add(this.label11);
            this.grpDetalle.Controls.Add(this.txtModelo);
            this.grpDetalle.Controls.Add(this.label10);
            this.grpDetalle.Controls.Add(this.txtMarca);
            this.grpDetalle.Controls.Add(this.label9);
            this.grpDetalle.Controls.Add(this.txtAño);
            this.grpDetalle.Controls.Add(this.txtPatente);
            this.grpDetalle.Controls.Add(this.txtPatenteTaxi);
            this.grpDetalle.Controls.Add(this.txtColor);
            this.grpDetalle.Controls.Add(this.label3);
            this.grpDetalle.Controls.Add(this.label8);
            this.grpDetalle.Controls.Add(this.label4);
            this.grpDetalle.Controls.Add(this.label7);
            this.grpDetalle.Location = new System.Drawing.Point(24, 18);
            this.grpDetalle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDetalle.Name = "grpDetalle";
            this.grpDetalle.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDetalle.Size = new System.Drawing.Size(587, 151);
            this.grpDetalle.TabIndex = 21;
            this.grpDetalle.TabStop = false;
            this.grpDetalle.Text = "Detalle del Chofer";
            // 
            // checkActivo
            // 
            this.checkActivo.AutoSize = true;
            this.checkActivo.Location = new System.Drawing.Point(118, 121);
            this.checkActivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkActivo.Name = "checkActivo";
            this.checkActivo.Size = new System.Drawing.Size(11, 11);
            this.checkActivo.TabIndex = 36;
            this.checkActivo.UseVisualStyleBackColor = true;
            this.checkActivo.CheckedChanged += new System.EventHandler(this.checkActivo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Es Taxi?";
            // 
            // txtKilometraje
            // 
            this.txtKilometraje.Location = new System.Drawing.Point(366, 83);
            this.txtKilometraje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKilometraje.MaxLength = 7;
            this.txtKilometraje.Name = "txtKilometraje";
            this.txtKilometraje.Size = new System.Drawing.Size(90, 20);
            this.txtKilometraje.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(294, 85);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 15);
            this.label11.TabIndex = 34;
            this.label11.Text = "Kilometraje";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(346, 56);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtModelo.MaxLength = 50;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(158, 20);
            this.txtModelo.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(295, 58);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 32;
            this.label10.Text = "Modelo";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(118, 55);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMarca.MaxLength = 50;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(162, 20);
            this.txtMarca.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(76, 57);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 15);
            this.label9.TabIndex = 30;
            this.label9.Text = "Marca";
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(249, 27);
            this.txtAño.Mask = "0000";
            this.txtAño.Name = "txtAño";
            this.txtAño.PromptChar = ' ';
            this.txtAño.Size = new System.Drawing.Size(31, 20);
            this.txtAño.TabIndex = 3;
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(118, 27);
            this.txtPatente.Mask = "AAA-000";
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.PromptChar = ' ';
            this.txtPatente.Size = new System.Drawing.Size(48, 20);
            this.txtPatente.TabIndex = 1;
            // 
            // txtPatenteTaxi
            // 
            this.txtPatenteTaxi.Enabled = false;
            this.txtPatenteTaxi.Location = new System.Drawing.Point(250, 116);
            this.txtPatenteTaxi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPatenteTaxi.MaxLength = 5;
            this.txtPatenteTaxi.Name = "txtPatenteTaxi";
            this.txtPatenteTaxi.Size = new System.Drawing.Size(48, 20);
            this.txtPatenteTaxi.TabIndex = 2;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(118, 86);
            this.txtColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtColor.MaxLength = 25;
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(162, 20);
            this.txtColor.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Color";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(65, 29);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Patente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(218, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Año";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(173, 118);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Patente Taxi";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(520, 184);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 42);
            this.btnCancelar.TabIndex = 9;
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
            this.btnGuardar.Location = new System.Drawing.Point(412, 184);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 42);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmChofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 235);
            this.Controls.Add(this.grpDetalle);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChofer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Datos Chofer";
            this.Load += new System.EventHandler(this.frmChofer_Load);
            this.grpDetalle.ResumeLayout(false);
            this.grpDetalle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDetalle;
        private System.Windows.Forms.TextBox txtKilometraje;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtAño;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.MaskedTextBox txtPatente;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtPatenteTaxi;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkActivo;
        private System.Windows.Forms.Label label1;
    }
}