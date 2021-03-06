﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora
{
    public class ControladoraEmpresas
    {
        private static volatile ControladoraEmpresas instancia;

        private ControladoraEmpresas()
        {
        }
        public static ControladoraEmpresas getINSTANCIA
        {
            get
            {
                if (instancia == null) instancia = new ControladoraEmpresas();
                return instancia;
            }
        }

        public void AgregarEmpresa(Modelo.Empresa oEmpresa)
        {
            Modelo.Datos.ObtenerInstancia().AddToEmpresas(oEmpresa);
            Modelo.Datos.ObtenerInstancia().SaveChanges();
        }
        public void EliminarEmpresa(Modelo.Empresa oEmpresa)
        {
            Modelo.Datos.ObtenerInstancia().DeleteObject(oEmpresa);
            Modelo.Datos.ObtenerInstancia().SaveChanges();
        }
        public void ModificarEmpresa(Modelo.Empresa oEmpresa)
        {
            Modelo.Datos.ObtenerInstancia().Empresas.ApplyCurrentValues(oEmpresa);
            Modelo.Datos.ObtenerInstancia().SaveChanges();
        }
        public List<Modelo.Empresa> ListarEmpresas()
        {
            return Modelo.Datos.ObtenerInstancia().Empresas.ToList();

        }

        public bool VerificarEmpresa(Modelo.Empresa oEmpresa)
        {
            List<Modelo.Empresa> Lista = Modelo.Datos.ObtenerInstancia().Empresas.Where(oEmpr => oEmpr.Cuit == oEmpresa.Cuit).ToList();

            if (Lista.Count > 0)    
            {
                return false;
            }
            return true;
        }

        public List<Modelo.Empresa> ListarEmpresasFiltradas(String RSocial, String Cuit)
       {
           List<Modelo.Empresa> Filtrado = Modelo.Datos.ObtenerInstancia().Empresas.OrderBy(c => c.Cuit).ToList();
           if (Cuit != "")
               Filtrado = Filtrado.Where(oEmp => oEmp.Cuit == Convert.ToInt32(Cuit)).ToList();
           if (RSocial != "")
               Filtrado = Filtrado.Where(oEmp => oEmp.RazonSocial==RSocial).ToList();

           return Filtrado;
       
       }
      }
}
