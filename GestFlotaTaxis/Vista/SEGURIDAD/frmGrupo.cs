using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo.SEGURIDAD;

namespace Vista.SEGURIDAD
{
    public partial class frmGrupo : Form
    {
        private string frmModo;
        Grupo miGrupo;
        Controladora.SEGURIDAD.ControladoraGrupos ctrlGrupos = new Controladora.SEGURIDAD.ControladoraGrupos();


        public frmGrupo()
        {
            InitializeComponent();
            frmModo = "ALTA";
            miGrupo = new Grupo();
        }

        public frmGrupo(string modo, Grupo oGrupo)
        {
            InitializeComponent();
            frmModo = modo;
            miGrupo = oGrupo;

            if (frmModo == "CONSULTA")
            {
                txtNombre.Enabled = false;
                txtDescripcion.Enabled = false;
                btnGuardar.Enabled = false;
                btnGuardar.Visible = false;
                txtNombre.Text = oGrupo.IDgrupo;
                txtDescripcion.Text = oGrupo.Descripcion;
            }
            if (frmModo == "MODIFICACION")
            {
                txtNombre.Enabled = false;
                txtNombre.Text = oGrupo.IDgrupo;
                txtDescripcion.Text = oGrupo.Descripcion;
                txtDescripcion.Focus();
            }
        }

        private void frmGrupo_Load(object sender, EventArgs e)
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre del grupo", "ATENCION");
                txtNombre.Focus();
                return;
            }
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Debe ingresar la descripción del grupo", "ATENCION");
                txtDescripcion.Focus();
                return;
            }

            
            miGrupo.IDgrupo = txtNombre.Text;
            miGrupo.Descripcion = txtDescripcion.Text;

                   
                    if (frmModo == "ALTA")
                    {
                        if (ctrlGrupos.VerificarGrupo(miGrupo))
                        {
                            ctrlGrupos.AgregarGrupo(miGrupo);
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("El Nombre ingresado ya existe. Ingrese un nombre de grupo inexistente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                        }
                    }

                    if (frmModo == "MODIFICACION")
                    {
                        ctrlGrupos.ModificarGrupo(miGrupo);
                        this.DialogResult = DialogResult.OK;
                    }
        }
         
    }

}

