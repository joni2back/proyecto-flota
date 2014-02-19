
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo.SEGURIDAD;

namespace Modelo
{
    public class Seguridad
    {
        private static SistFlota_Seguridad_ModeloContainer Instancia = null;

        private Seguridad()
        { }

        public static SistFlota_Seguridad_ModeloContainer ObtenerInstancia()
        {
            if (Instancia == null)
            {
                Instancia = new SistFlota_Seguridad_ModeloContainer();
            }

            return Instancia;
        }
    }
}