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
            this.label5 = new System.Windows.Forms.Label();
            this.imgFotoChofer = new System.Windows.Forms.PictureBox();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLicencia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminarFoto = new System.Windows.Forms.Button();
            this.grpDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFotoChofer)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDetalle
            // 
            this.grpDetalle.Controls.Add(this.btnEliminarFoto);
            this.grpDetalle.Controls.Add(this.label5);
            this.grpDetalle.Controls.Add(this.imgFotoChofer);
            this.grpDetalle.Controls.Add(this.txtCorreoElectronico);
            this.grpDetalle.Controls.Add(this.txtTelefono);
            this.grpDetalle.Controls.Add(this.txtDomicilio);
            this.grpDetalle.Controls.Add(this.txtNombre);
            this.grpDetalle.Controls.Add(this.txtApellido);
            this.grpDetalle.Controls.Add(this.label2);
            this.grpDetalle.Controls.Add(this.label1);
            this.grpDetalle.Controls.Add(this.txtLocalidad);
            this.grpDetalle.Controls.Add(this.label11);
            this.grpDetalle.Controls.Add(this.txtLicencia);
            this.grpDetalle.Controls.Add(this.label10);
            this.grpDetalle.Controls.Add(this.txtDocumento);
            this.grpDetalle.Controls.Add(this.label9);
            this.grpDetalle.Controls.Add(this.txtFechaNacimiento);
            this.grpDetalle.Controls.Add(this.label3);
            this.grpDetalle.Controls.Add(this.label8);
            this.grpDetalle.Controls.Add(this.label4);
            this.grpDetalle.Controls.Add(this.label7);
            this.grpDetalle.Location = new System.Drawing.Point(24, 18);
            this.grpDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.grpDetalle.Name = "grpDetalle";
            this.grpDetalle.Padding = new System.Windows.Forms.Padding(2);
            this.grpDetalle.Size = new System.Drawing.Size(587, 258);
            this.grpDetalle.TabIndex = 21;
            this.grpDetalle.TabStop = false;
            this.grpDetalle.Text = "Detalle del Chofer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(360, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 44;
            this.label5.Text = "Foto";
            // 
            // imgFotoChofer
            // 
            this.imgFotoChofer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.imgFotoChofer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgFotoChofer.BackgroundImage")));
            this.imgFotoChofer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgFotoChofer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgFotoChofer.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imgFotoChofer.ErrorImage")));
            this.imgFotoChofer.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgFotoChofer.InitialImage")));
            this.imgFotoChofer.Location = new System.Drawing.Point(396, 88);
            this.imgFotoChofer.Name = "imgFotoChofer";
            this.imgFotoChofer.Size = new System.Drawing.Size(143, 140);
            this.imgFotoChofer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFotoChofer.TabIndex = 43;
            this.imgFotoChofer.TabStop = false;
            this.imgFotoChofer.Click += new System.EventHandler(this.imgFotoChofer_Click);
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(175, 211);
            this.txtCorreoElectronico.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreoElectronico.MaxLength = 50;
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(184, 20);
            this.txtCorreoElectronico.TabIndex = 42;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(140, 181);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.MaxLength = 50;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(143, 20);
            this.txtTelefono.TabIndex = 41;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(145, 148);
            this.txtDomicilio.Margin = new System.Windows.Forms.Padding(2);
            this.txtDomicilio.MaxLength = 50;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(143, 20);
            this.txtDomicilio.TabIndex = 40;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(140, 27);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(149, 20);
            this.txtNombre.TabIndex = 39;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(396, 24);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(143, 20);
            this.txtApellido.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 36;
            this.label2.Text = "Correo Electronico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Domicilio";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(145, 118);
            this.txtLocalidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocalidad.MaxLength = 7;
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(144, 20);
            this.txtLocalidad.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(65, 120);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 15);
            this.label11.TabIndex = 34;
            this.label11.Text = "Localidad";
            // 
            // txtLicencia
            // 
            this.txtLicencia.Location = new System.Drawing.Point(396, 55);
            this.txtLicencia.Margin = new System.Windows.Forms.Padding(2);
            this.txtLicencia.MaxLength = 50;
            this.txtLicencia.Name = "txtLicencia";
            this.txtLicencia.Size = new System.Drawing.Size(143, 20);
            this.txtLicencia.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(319, 58);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 15);
            this.label10.TabIndex = 32;
            this.label10.Text = "Licencia Nro";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(140, 55);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.txtDocumento.MaxLength = 50;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(149, 20);
            this.txtDocumento.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(65, 57);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 15);
            this.label9.TabIndex = 30;
            this.label9.Text = "Documento";
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(173, 86);
            this.txtFechaNacimiento.Margin = new System.Windows.Forms.Padding(2);
            this.txtFechaNacimiento.MaxLength = 25;
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(116, 20);
            this.txtFechaNacimiento.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Fecha Nacimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(65, 29);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(319, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 181);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Telefono";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(526, 280);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnGuardar.Location = new System.Drawing.Point(418, 280);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 42);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminarFoto
            // 
            this.btnEliminarFoto.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarFoto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminarFoto.Location = new System.Drawing.Point(396, 229);
            this.btnEliminarFoto.Margin = new System.Windows.Forms.Padding(1);
            this.btnEliminarFoto.Name = "btnEliminarFoto";
            this.btnEliminarFoto.Size = new System.Drawing.Size(143, 19);
            this.btnEliminarFoto.TabIndex = 45;
            this.btnEliminarFoto.Text = "ELIMINAR FOTO";
            this.btnEliminarFoto.UseVisualStyleBackColor = true;
            this.btnEliminarFoto.Click += new System.EventHandler(this.btnEliminarFoto_Click);
            // 
            // frmChofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 333);
            this.Controls.Add(this.grpDetalle);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
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
            ((System.ComponentModel.ISupportInitialize)(this.imgFotoChofer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDetalle;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLicencia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox imgFotoChofer;
        private System.Windows.Forms.Button btnEliminarFoto;
    }
}