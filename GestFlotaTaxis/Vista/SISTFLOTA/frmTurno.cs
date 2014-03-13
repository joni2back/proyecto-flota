using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo.SEGURIDAD;

namespace Vista.SistFlota
{
    public partial class frmTurno : Form
    {
        string frmModo;
        Modelo.Turno oTurno;
        //Modelo.AUDITORIA.AudTurnos oTurnoAUDI = new Modelo.AUDITORIA.AudTurnos();
        Usuario oUsuarioActual;
        //Controladora.AUDITORIA.ControladoraAudTurnos ctrlAudTurnos = new Controladora.AUDITORIA.ControladoraAudTurnos();
        Controladora.ControladoraVehiculos ctrlVehiculos = Controladora.ControladoraVehiculos.getINSTANCIA;
        Controladora.ControladoraTurnos ctrlTurnos = Controladora.ControladoraTurnos.getINSTANCIA;
        Controladora.ControladoraChoferes ctrlChoferes = Controladora.ControladoraChoferes.getINSTANCIA;


        public frmTurno(Usuario oUsuario)
        {
            InitializeComponent();
            frmModo = "ALTA";

            oUsuarioActual = oUsuario;

            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Value = DateTime.Now;

            oTurno = new Modelo.Turno();
            CargarCombos();
        }

        public frmTurno(string modo, Modelo.Turno oTurnoR, Usuario oUsuario)
        {
            InitializeComponent();
            frmModo = modo;

            oUsuarioActual = oUsuario;

            oTurno = oTurnoR;

            if (frmModo == "MODIFICACION")
            {
                //oTurnoAUDI = oTurno;

                //oTurnoAUDI.IdTurno = oTurno.Id;
                //oTurnoAUDI.Descripcion = oTurno.Descripcion;
                //oTurnoAUDI.Monto = oTurno.Monto;
                //oTurnoAUDI.Estado = oTurno.Estado;
                //oTurnoAUDI.FechaVencimiento = oTurno.FechaVencimiento;
                //oTurnoAUDI.HoraEmision = oTurno.HoraEmision;
                //oTurnoAUDI.FechaEmision = oTurno.FechaEmision;
                //oTurnoAUDI.TipodeTurno = oTurno.TipodeTurno.Id;
                //oTurnoAUDI.Vehiculo = oTurno.Vehiculo.Patente;
                //oTurnoAUDI.Usuario = oTurno.Usuario;
                //oTurnoAUDI.FechayHora = oTurno.FechayHora;
                //oTurnoAUDI.Operacion = oTurno.Operacion;

                txtId.Enabled = false;
            }

            if (frmModo == "CONSULTA")
            {
                grpDetalle.Enabled = false;
                btnGuardar.Enabled = false;
            }
            CargarCombos();
            LlenarCampos(oTurno);
        }

        private void frmTurno_Load(object sender, EventArgs e)
        {
            VerificarTipo();
        }

        private void CargarCombos()
        {
            bdsVehiculos.Sort = null;
            bdsVehiculos.DataSource = null;
            bdsVehiculos.Clear();
            bdsVehiculos.DataSource = ctrlVehiculos.ListarVehiculos();
            cbxVehiculo.SelectedItem = null;

            bdsChoferes.Sort = null;
            bdsChoferes.DataSource = null;
            bdsChoferes.Clear();
            bdsChoferes.DataSource = ctrlChoferes.ListarChoferes();
            //cbxTipoTurno.SelectedItem = null;

            if (cbxTurno.Items.Count == 0)
            {
                cbxTurno.Items.Add("PENDIENTE");
                cbxTurno.Items.Add("PAGADO");
            }
            cbxTurno.SelectedItem = "PENDIENTE";
       
        }



        private void LlenarCampos(Modelo.Turno oTurno)
        {
            txtId.Text = oTurno.Id.ToString();
            //cbxVehiculo.SelectedItem = oTurno.Vehiculo;
            //cbxTipoTurno.SelectedItem = oTurno.TipodeTurno;
            //cbxEstado.SelectedItem = oTurno.Estado;
            //txtDescripcion.Text = oTurno.Descripcion;
            //txtMonto.Text = oTurno.Monto.ToString();
            
            //if (oTurno.FechaEmision != null)
            //dtpFechaEmision.Value = oTurno.FechaEmision.Value;
            //if (oTurno.HoraEmision != null)
            //dtpHoraEmision.Value = Convert.ToDateTime(oTurno.HoraEmision.Value);

            //dtpFechaVencimientoPago.Value = oTurno.FechaVencimiento;

            //if (cbxEstado.Text == "PAGADO")
            //{
            //    dtpFechaVencimientoPago.Value = oTurno.FechayHora;
            //}

        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (ValidarCampos())
            {
                
                //oTurno.Vehiculo = (Modelo.Vehiculo)bdsVehiculos.Current;
                //oTurno.TipodeTurno = (Modelo.TipodeTurno)bdsChoferes.Current;
                //oTurno.Estado = cbxEstado.Text.ToUpper();
                //oTurno.Descripcion = txtDescripcion.Text.ToUpper();
                //oTurno.Monto = Convert.ToDecimal(txtMonto.Text);
                //oTurno.FechaVencimiento = dtpFechaVencimientoPago.Value.Date;

                //oTurno.Usuario = oUsuarioActual.IDusuario;
                //oTurno.FechayHora = DateTime.Now;

                
                if (frmModo == "ALTA")
                {

                            //oTurno.Operacion = "ALTA";
                            //ctrlTurnos.AgregarTurno(oTurno);
                            //this.DialogResult = DialogResult.OK;

                }
                if (frmModo == "MODIFICACION")
                {

                  //  oTurno.Operacion = "MODIFICACION";
                  ////  oTurno.Id = Convert.ToInt32(txtId.Text);
                  //  ctrlAudTurnos.AuditarTurnosMOD(oTurnoAUDI);
                  //  ctrlTurnos.ModificarTurno(oTurno);
                  //      this.DialogResult = DialogResult.OK;

                }
            }


        }

        private void VerificarTipo()
        {
            //if (cbxTipoTurno.Text == "INFRACCION")
            //{
            //    dtpFechaEmision.Visible = true;
            //    dtpHoraEmision.Visible = true;
            //    lblFechaEmision.Visible = true;
            //    lblHoraEmision.Visible = true;

            //    //dtpFechaEmision.TabIndex = 8;
            //    //dtpHoraEmision.TabIndex = 9;

            //}
            //else
            //{
            //    dtpFechaEmision.Visible = false;
            //    dtpHoraEmision.Visible = false;
            //    lblFechaEmision.Visible = false;
            //    lblHoraEmision.Visible = false;
            //}
        }


        private void cbxTipoTurno_SelectedValueChanged(object sender, EventArgs e)
        {
            VerificarTipo();
        }


        public bool ValidarCampos()
        {


            if (cbxVehiculo.Text == "")
            {
                cbxVehiculo.Focus();
                MessageBox.Show("Complete el vehiculo asociado al turno", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cbxChofer.Text == "")
            {
                cbxChofer.Focus();
                MessageBox.Show("Complete el tipo de turno del turno", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (txtComentarios.Text == "")
            {
                //txtDescripcion.Focus();
                //MessageBox.Show("Complete la descripción del turno", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //txtDescripcion.Text = cbxTipoTurno.Text.ToString();
                //return false;
            }


            if (txtKmRecorridos.Text == "")
            {
                txtKmRecorridos.Focus();
                MessageBox.Show("Complete el monto del turno", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try {
                Convert.ToDecimal(txtKmRecorridos.Text);
                }
            catch{
                txtKmRecorridos.Focus();
                MessageBox.Show("La cantidad de Kilometros Recorridos debe ser numérica", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (dtpFecha.Text == "")
            {
                dtpFecha.Focus();
                MessageBox.Show("Complete la fecha de vencimiento del turno", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            
            if (dtpFecha.Value.Date > DateTime.Today.Date)
            {
                dtpFecha.Focus();
                MessageBox.Show("La fecha del turno no puede ser posterior a la fecha de hoy", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (txtHorasTrabajadas.Text == "")
            {
                txtHorasTrabajadas.Focus();
                MessageBox.Show("Complete las horas trabajadas del turno", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

         return true;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxEstado_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarCC_Click(object sender, EventArgs e)
        {
            /*frmCuentasCorrientes ofrmCC = new frmCuentasCorrientes(oTurno);

            DialogResult drABIERTO = ofrmCC.ShowDialog();*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }



    }
}
