using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Controladora.SISTFLOTA;

namespace Controladora.SISTFLOTA.Adapter
{
    public interface Target
    {
        ControladoraVehiculos OBTENER_INSTANCIA();
    }
}
