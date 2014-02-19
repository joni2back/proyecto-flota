using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Datos
    {
        private static SistFlota_ModeloDatosContainer Instancia = null;

        private Datos()
        { }

        public static SistFlota_ModeloDatosContainer ObtenerInstancia()
        {
            if (Instancia == null)
            {
                Instancia = new SistFlota_ModeloDatosContainer();
            }

            return Instancia;
        }
    }
}
