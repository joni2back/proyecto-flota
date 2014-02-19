using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora.SISTFLOTA.Strategy
{
    public class Contexto
    {
        public static Controladora.SISTFLOTA.Strategy.Contexto instancia;
        public Controladora.SISTFLOTA.Strategy.IStrategy iStrategy;

        private Contexto(Controladora.SISTFLOTA.Strategy.IStrategy strategia)
        {
            this.iStrategy = strategia;
        }

        public static Contexto getINSTANCIA(Controladora.SISTFLOTA.Strategy.IStrategy strategia)
        {
            instancia = new Contexto(strategia);
            return instancia;
        }
        public void Hacer_Reporte(string Reporte)
        {
            switch (Reporte)
            {
                case "Reporte_Gastos":
                    this.iStrategy.GenerarReporteGastos();
                    break;

                case "Reporte_VehiculosActivos":
                    this.iStrategy.GenerarReporteVehiculosActivos();
                    break;
            }
        }
    }
}
