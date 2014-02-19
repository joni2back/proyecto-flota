using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo.AUDITORIA;

namespace Modelo
{
    public class Auditoria
    {

        private static SistFlota_Auditoria_ModeloContainer Instancia = null;

        private Auditoria()
        { }

        public static SistFlota_Auditoria_ModeloContainer ObtenerInstancia()
        {
            if (Instancia == null)
            {
                Instancia = new SistFlota_Auditoria_ModeloContainer();
            }

            return Instancia;
        }

    }
}



