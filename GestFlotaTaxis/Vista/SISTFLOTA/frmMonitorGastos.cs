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
    public partial class frmMonitorGastos : Form
    {
        Modelo.Gasto oGasto;
        Usuario oUsuarioActual;
        Controladora.AUDITORIA.ControladoraAudGastos ctrlAudGastos = new Controladora.AUDITORIA.ControladoraAudGastos();
        Controladora.ControladoraGastos ctrlGastos = new Controladora.ControladoraGastos();


        public frmMonitorGastos(Usuario oUsuario)
        {
            oUsuarioActual = oUsuario;
            InitializeComponent();

            btnPagar.Visible = false;
        }

        public void LlenarGrilla()
        {
            bdsGastos.Sort = null;
            bdsGastos.DataSource = null;
            bdsGastos.Clear();
            bdsGastos.DataSource = ctrlGastos.ListarGastosMonitor();

            if (bdsGastos.Count == 0)
                lblSinResultados.Visible = true;
            else
                lblSinResultados.Visible = false;
        }

        private void frmMonitorGastos_Load(object sender, EventArgs e)
        {
            LlenarGrilla();
            ArmarPerfil();
        }


        private void ArmarPerfil()
        {
            bool admin = false;

            foreach (Grupo g in oUsuarioActual.Grupo)
                if (g.IDgrupo == "Administrador")
                {
                    admin = true;
                }

            if (admin)
            {
                btnPagar.Visible = true;
            }
            else
            {
                Controladora.SEGURIDAD.ControladoraPerfiles ctrlPerfiles = new Controladora.SEGURIDAD.ControladoraPerfiles();

                List<Modelo.SEGURIDAD.Permiso> _PERMISOS = new List<Modelo.SEGURIDAD.Permiso>();
                _PERMISOS = ctrlPerfiles.ObtenerPermisos(this.Name.ToString().Substring(3), oUsuarioActual);

                foreach (Modelo.SEGURIDAD.Permiso oPERMISO in _PERMISOS)
                {
                    switch (oPERMISO.IDpermiso)
                    {
                        case "TOTAL": btnPagar.Visible = true; break;

                    }
                }
            }
        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void grillaVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LlenarCampos();
        }

        private void LlenarCampos()
        {
            if (bdsGastos.Current != null)
            {
                oGasto = (Modelo.Gasto)bdsGastos.Current;

                txtVehiculo.Text = oGasto.Vehiculo.Patente;
                txtTipodeGasto.Text = oGasto.TipodeGasto.Descripcion;
                txtDescripcion.Text = oGasto.Descripcion;
                txtMonto.Text = "$ " + oGasto.Monto.ToString();
                txtFechaVencimiento.Text = oGasto.FechaVencimiento.Date.ToShortDateString();
                
                btnPagar.Enabled = true;

                if (oGasto.FechaVencimiento.Date <= DateTime.Today.Date.AddDays(15))
                {
                    ImgVerde.Visible = true;
                    ImgAmarillo.Visible = false;
                    ImgRojo.Visible = false;
                    ImgVacio.Visible = false;
                }
                if (oGasto.FechaVencimiento.Date <= DateTime.Today.Date.AddDays(7))
                {
                    ImgVerde.Visible = false;
                    ImgAmarillo.Visible = true;
                    ImgRojo.Visible = false;
                    ImgVacio.Visible = false;
                }
                if (oGasto.FechaVencimiento.Date <= DateTime.Today.Date.AddDays(2))
                {
                    ImgVerde.Visible = false;
                    ImgAmarillo.Visible = false;
                    ImgRojo.Visible = true;
                    ImgVacio.Visible = false;
                }
            }
                else
                {
                    ImgVacio.Visible = true;
                    LimpiarCampos();
                }
        }


        public void LimpiarCampos()
        {
            txtVehiculo.Clear();
            txtTipodeGasto.Clear();
            txtDescripcion.Clear();
            txtMonto.Clear();
            txtFechaVencimiento.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            oGasto = (Modelo.Gasto)bdsGastos.Current;
            //  oGasto.Id = Convert.ToInt32(txtId.Text);

            Modelo.AUDITORIA.AudGastos oGastoAUDI = new Modelo.AUDITORIA.AudGastos();

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

            ctrlAudGastos.AuditarGastosMOD(oGastoAUDI);
            oGasto.Pagar(oUsuarioActual);
            LlenarGrilla();
            LlenarCampos();

        }

        private void grillaVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
