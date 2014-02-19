using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Controladora.SISTFLOTA;

namespace Controladora.SISTFLOTA.Adapter
{
    public class Adapter : Target
    {
        public ControladoraVehiculos MiGestVehiculos;

        public ControladoraVehiculos OBTENER_INSTANCIA()
        {
            MiGestVehiculos = ControladoraVehiculos.getINSTANCIA;
            return MiGestVehiculos;
        }
    }
}
