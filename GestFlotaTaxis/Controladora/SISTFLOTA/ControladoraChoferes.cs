﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora
{
    public class ControladoraChoferes
    {
        private static volatile ControladoraChoferes instancia;

        private ControladoraChoferes()
        {
        }
        public static ControladoraChoferes getINSTANCIA
        {
            get
            {
                if (instancia == null) instancia = new ControladoraChoferes();
                return instancia;
            }
        }

        public void AgregarChofer(Modelo.Chofer oChofer)
        {
            Modelo.Datos.ObtenerInstancia().AddToChoferes(oChofer);
            Modelo.Datos.ObtenerInstancia().SaveChanges();
        }
        public void EliminarChofer(Modelo.Chofer oChofer)
        {
            Modelo.Datos.ObtenerInstancia().DeleteObject(oChofer);
            Modelo.Datos.ObtenerInstancia().SaveChanges();
        }
        public void ModificarChofer(Modelo.Chofer oChofer)
        {
            Modelo.Datos.ObtenerInstancia().Choferes.ApplyCurrentValues(oChofer);
            Modelo.Datos.ObtenerInstancia().SaveChanges();
        }
        public List<Modelo.Chofer> ListarChoferes()
        {
            return Modelo.Datos.ObtenerInstancia().Choferes.ToList();

        }

        public bool VerificarChofer(Modelo.Chofer oChofer)
        {
            List<Modelo.Chofer> Lista = Modelo.Datos.ObtenerInstancia().Choferes.Where(oChof => oChof.Documento == oChofer.Documento).ToList();

            if (Lista.Count > 0)    
            {
                return false;
            }
            return true;
        }

        public bool VerificarLicencia(Modelo.Chofer oChofer)
        {
            List<Modelo.Chofer> Lista = Modelo.Datos.ObtenerInstancia().Choferes.Where(oChof => oChof.Licencia == oChofer.Licencia).ToList();

            if (Lista.Count > 0)
            {
                return false;
            }
            return true;
        }


    }
}
