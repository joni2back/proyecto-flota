using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public partial class Gasto
    {
        public string PatVehiculo
        {
            get
            {
                return Vehiculo.Patente;
            }
        }

        public string TipoGasto
        {
            get
            {
                return TipodeGasto.Descripcion;
            }
        }

        public void Pagar(Modelo.SEGURIDAD.Usuario oUsuario)
        {
            Estado = "PAGADO";
            FechaVencimiento = DateTime.Now;
            Operacion = "MODIFICACION";
            Usuario = oUsuario.IDusuario;
            FechayHora = DateTime.Now;
        }

    }
}
