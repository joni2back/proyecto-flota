namespace Vista.SEGURIDAD
{
    partial class frmPerfil
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerfil));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxPermiso = new System.Windows.Forms.ComboBox();
            this.bdsPermisos = new System.Windows.Forms.BindingSource(this.components);
            this.cbxFormulario = new System.Windows.Forms.ComboBox();
            this.bdsFormularios = new System.Windows.Forms.BindingSource(this.components);
            this.cbxGrupo = new System.Windows.Forms.ComboBox();
            this.bdsGrupos = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsFormularios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGrupos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxPermiso);
            this.groupBox1.Controls.Add(this.cbxFormulario);
            this.groupBox1.Controls.Add(this.cbxGrupo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 159);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Perfil";
            // 
            // cbxPermiso
            // 
            this.cbxPermiso.DataSource = this.bdsPermisos;
            this.cbxPermiso.DisplayMember = "IDpermiso";
            this.cbxPermiso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPermiso.FormattingEnabled = true;
            this.cbxPermiso.Location = new System.Drawing.Point(111, 110);
            this.cbxPermiso.Name = "cbxPermiso";
            this.cbxPermiso.Size = new System.Drawing.Size(164, 21);
            this.cbxPermiso.TabIndex = 19;
            // 
            // bdsPermisos
            // 
            this.bdsPermisos.DataSource = typeof(Modelo.SEGURIDAD.Permiso);
            // 
            // cbxFormulario
            // 
            this.cbxFormulario.DataSource = this.bdsFormularios;
            this.cbxFormulario.DisplayMember = "IDformulario";
            this.cbxFormulario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFormulario.FormattingEnabled = true;
            this.cbxFormulario.Location = new System.Drawing.Point(111, 69);
            this.cbxFormulario.Name = "cbxFormulario";
            this.cbxFormulario.Size = new System.Drawing.Size(164, 21);
            this.cbxFormulario.TabIndex = 18;
            // 
            // bdsFormularios
            // 
            this.bdsFormularios.DataSource = typeof(Modelo.SEGURIDAD.Formulario);
            // 
            // cbxGrupo
            // 
            this.cbxGrupo.DataSource = this.bdsGrupos;
            this.cbxGrupo.DisplayMember = "IDgrupo";
            this.cbxGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGrupo.FormattingEnabled = true;
            this.cbxGrupo.Location = new System.Drawing.Point(111, 29);
            this.cbxGrupo.Name = "cbxGrupo";
            this.cbxGrupo.Size = new System.Drawing.Size(164, 21);
            this.cbxGrupo.TabIndex = 17;
            // 
            // bdsGrupos
            // 
            this.bdsGrupos.DataSource = typeof(Modelo.SEGURIDAD.Grupo);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Permiso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Formulario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Grupo";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(243, 188);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 42);
            this.btnCancelar.TabIndex = 20;
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
            this.btnGuardar.Location = new System.Drawing.Point(135, 188);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 42);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 240);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPerfil";
            this.Text = "Datos de Perfil";
            this.Load += new System.EventHandler(this.frmPerfil_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsFormularios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGrupos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cbxPermiso;
        private System.Windows.Forms.ComboBox cbxFormulario;
        private System.Windows.Forms.ComboBox cbxGrupo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bdsGrupos;
        private System.Windows.Forms.BindingSource bdsFormularios;
        private System.Windows.Forms.BindingSource bdsPermisos;
    }
}