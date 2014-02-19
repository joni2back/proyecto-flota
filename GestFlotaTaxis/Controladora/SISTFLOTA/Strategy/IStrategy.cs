﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora.SISTFLOTA.Strategy
{
    public interface IStrategy
    {
        void GenerarReporteGastos();

        void GenerarReporteVehiculosActivos();
    }

}
