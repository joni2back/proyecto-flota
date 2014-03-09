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
    public partial class frmGasto : Form
    {
        string frmModo;
        Modelo.Gasto oGasto;
        Modelo.AUDITORIA.AudGastos oGastoAUDI = new Modelo.AUDITORIA.AudGastos();
        Usuario oUsuarioActual;
        Controladora.AUDITORIA.ControladoraAudGastos ctrlAudGastos = new Controladora.AUDITORIA.ControladoraAudGastos();
        Controladora.ControladoraTiposdeGasto ctrlTipoGasto = new Controladora.ControladoraTiposdeGasto();
        Controladora.ControladoraVehiculos ctrlVehiculos = Controladora.ControladoraVehiculos.getINSTANCIA;
        Controladora.ControladoraGastos ctrlGastos = new Controladora.ControladoraGastos();


        public frmGasto(Usuario oUsuario)
        {
            InitializeComponent();
            frmModo = "ALTA";

            oUsuarioActual = oUsuario;

            dtpFechaVencimientoPago.Format = DateTimePickerFormat.Short;
            dtpFechaVencimientoPago.Value = DateTime.Now;

            dtpHoraEmision.Value = DateTime.Now;
            dtpHoraEmision.Value = DateTime.Now;
            oGasto = new Modelo.Gasto();
            CargarCombos();
        }

        public frmGasto(string modo, Modelo.Gasto oGastoR, Usuario oUsuario)
        {
            InitializeComponent();
            frmModo = modo;

            oUsuarioActual = oUsuario;

            oGasto = oGastoR;

            if (frmModo == "MODIFICACION")
            {
                //oGastoAUDI = oGasto;

                oGastoAUDI.IdGasto = oGasto.Id;
                oGastoAUDI.Descripcion = oGasto.Descripcion;
                oGastoAUDI.Monto = oGasto.Monto;
                oGastoAUDI.Estado = oGasto.Estado;
                oGastoAUDI.FechaVencimiento = oGasto.FechaVencimiento;
                oGastoAUDI.HoraEmision = oGasto.HoraEmision;
                oGastoAUDI.FechaEmision = oGasto.FechaEmision;
                oGastoAUDI.TipodeGasto = oGasto.TipodeGasto.Id;
                oGastoAUDI.Vehiculo = oGasto.Vehiculo.Patente;
                oGastoAUDI.Usuario = oGasto.Usuario;
                oGastoAUDI.FechayHora = oGasto.FechayHora;
                oGastoAUDI.Operacion = oGasto.Operacion;

                txtId.Enabled = false;
            }

            if (frmModo == "CONSULTA")
            {
                grpDetalle.Enabled = false;
                btnGuardar.Enabled = false;
            }
            CargarCombos();
            LlenarCampos(oGasto);
        }

        private void frmGasto_Load(object sender, EventArgs e)
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

            bdsTipodeGasto.Sort = null;
            bdsTipodeGasto.DataSource = null;
            bdsTipodeGasto.Clear();
            bdsTipodeGasto.DataSource = ctrlTipoGasto.ListarTiposdeGasto();
            cbxTipoGasto.SelectedItem = null;

            if (cbxEstado.Items.Count == 0)
            {
                cbxEstado.Items.Add("PENDIENTE");
                cbxEstado.Items.Add("PAGADO");
            }
            cbxEstado.SelectedItem = "PENDIENTE";
       
        }



        private void LlenarCampos(Modelo.Gasto oGasto)
        {
            txtId.Text = oGasto.Id.ToString();
            cbxVehiculo.SelectedItem = oGasto.Vehiculo;
            cbxTipoGasto.SelectedItem = oGasto.TipodeGasto;
            cbxEstado.SelectedItem = oGasto.Estado;
            txtDescripcion.Text = oGasto.Descripcion;
            txtMonto.Text = oGasto.Monto.ToString();
            
            if (oGasto.FechaEmision != null)
            dtpFechaEmision.Value = oGasto.FechaEmision.Value;
            if (oGasto.HoraEmision != null)
            dtpHoraEmision.Value = Convert.ToDateTime(oGasto.HoraEmision.Value);

            dtpFechaVencimientoPago.Value = oGasto.FechaVencimiento;

            //if (cbxEstado.Text == "PAGADO")
            //{
            //    dtpFechaVencimientoPago.Value = oGasto.FechayHora;
            //}

        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (ValidarCampos())
            {
                
                oGasto.Vehiculo = (Modelo.Vehiculo)bdsVehiculos.Current;
                oGasto.TipodeGasto = (Modelo.TipodeGasto)bdsTipodeGasto.Current;
                oGasto.Estado = cbxEstado.Text.ToUpper();
                oGasto.Descripcion = txtDescripcion.Text.ToUpper();
                oGasto.Monto = Convert.ToDecimal(txtMonto.Text);
                oGasto.FechaVencimiento = dtpFechaVencimientoPago.Value.Date;

                //if (cbxEstado.Text == "PAGADO")
                //{
                //    oGasto.FechayHora = dtpFechaVencimientoPago.Value.Date;
                //}


                oGasto.Usuario = oUsuarioActual.IDusuario;
                oGasto.FechayHora = DateTime.Now;

                
                if (cbxTipoGasto.Text == "INFRACCION")
                {
                    oGasto.FechaEmision = dtpFechaEmision.Value.Date;
                    oGasto.HoraEmision = dtpHoraEmision.Value;
                 }

                if (frmModo == "ALTA")
                {

                            oGasto.Operacion = "ALTA";
                            ctrlGastos.AgregarGasto(oGasto);
                            this.DialogResult = DialogResult.OK;

                }
                if (frmModo == "MODIFICACION")
                {

                    oGasto.Operacion = "MODIFICACION";
                  //  oGasto.Id = Convert.ToInt32(txtId.Text);
                    ctrlAudGastos.AuditarGastosMOD(oGastoAUDI);
                    ctrlGastos.ModificarGasto(oGasto);
                        this.DialogResult = DialogResult.OK;

                }
            }


        }

        private void VerificarTipo()
        {
            if (cbxTipoGasto.Text == "INFRACCION")
            {
                dtpFechaEmision.Visible = true;
                dtpHoraEmision.Visible = true;
                lblFechaEmision.Visible = true;
                lblHoraEmision.Visible = true;

                //dtpFechaEmision.TabIndex = 8;
                //dtpHoraEmision.TabIndex = 9;

            }
            else
            {
                dtpFechaEmision.Visible = false;
                dtpHoraEmision.Visible = false;
                lblFechaEmision.Visible = false;
                lblHoraEmision.Visible = false;
            }
        }


        private void cbxTipoGasto_SelectedValueChanged(object sender, EventArgs e)
        {
            VerificarTipo();
        }


        public bool ValidarCampos()
        {


            if (cbxVehiculo.Text == "")
            {
                cbxVehiculo.Focus();
                MessageBox.Show("Complete el vehiculo asociado al gasto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cbxTipoGasto.Text == "")
            {
                cbxTipoGasto.Focus();
                MessageBox.Show("Complete el tipo de gasto del gasto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (txtDescripcion.Text == "")
            {
                //txtDescripcion.Focus();
                //MessageBox.Show("Complete la descripción del gasto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripcion.Text = cbxTipoGasto.Text.ToString();
                //return false;
            }


            if (txtMonto.Text == "")
            {
                txtMonto.Focus();
                MessageBox.Show("Complete el monto del gasto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try {
                Convert.ToDecimal(txtMonto.Text);
                }
            catch {
                txtMonto.Focus();
                MessageBox.Show("El monto del gasto debe ser numérico", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (dtpFechaVencimientoPago.Text == "")
            {
                dtpFechaVencimientoPago.Focus();
                MessageBox.Show("Complete la fecha de vencimiento del gasto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cbxTipoGasto.Text == "INFRACCION")
            {
                if (dtpFechaEmision.Text == "")
                {
                    dtpFechaEmision.Focus();
                    MessageBox.Show("Complete la fecha de emisión de la infracción", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (dtpFechaEmision.Value.Date > DateTime.Today.Date)
                {
                    dtpFechaEmision.Focus();
                    MessageBox.Show("La fecha de emisión de la infracción no puede ser posterior a la fecha de hoy", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }


                if (dtpHoraEmision.Text == "")
                {
                    dtpHoraEmision.Focus();
                    MessageBox.Show("Complete la hora de emisión de la infracción", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }


            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxEstado.Text == "PAGADO")
            {
                lblFechaPV.Text = "Fecha de Pago";
            }
            else
            {
                lblFechaPV.Text = "Fecha Vencimiento";
            }

        }



    }
}
