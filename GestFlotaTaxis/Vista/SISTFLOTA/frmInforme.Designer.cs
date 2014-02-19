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
            ((System.ComponentModel.ISupportInitialize)(this.bdsInforme)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(516, 162);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(132, 52);
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
            this.btnVehiculosGastos.Location = new System.Drawing.Point(166, 20);
            this.btnVehiculosGastos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVehiculosGastos.Name = "btnVehiculosGastos";
            this.btnVehiculosGastos.Size = new System.Drawing.Size(467, 52);
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
            this.btnVehiculosActivos.Location = new System.Drawing.Point(166, 92);
            this.btnVehiculosActivos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVehiculosActivos.Name = "btnVehiculosActivos";
            this.btnVehiculosActivos.Size = new System.Drawing.Size(467, 52);
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
            this.cbTipo.Location = new System.Drawing.Point(12, 48);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 24);
            this.cbTipo.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Formato:";
            // 
            // frmInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 228);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.btnVehiculosActivos);
            this.Controls.Add(this.btnVehiculosGastos);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInforme";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Informes";
            this.Load += new System.EventHandler(this.frmInforme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsInforme)).EndInit();
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
    }
}