using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora
{
    public class ControladoraGastos
    {

        public void AgregarGasto(Modelo.Gasto oGasto)
        {
            Modelo.Datos.ObtenerInstancia().AddToGastos(oGasto);
            Modelo.Datos.ObtenerInstancia().SaveChanges();
        }
        public void EliminarGasto(Modelo.Gasto oGasto)
        {
            Modelo.Datos.ObtenerInstancia().DeleteObject(oGasto);
            Modelo.Datos.ObtenerInstancia().SaveChanges();
        }
        public void ModificarGasto(Modelo.Gasto oGasto)
        {
            Modelo.Datos.ObtenerInstancia().Gastos.ApplyCurrentValues(oGasto);
            Modelo.Datos.ObtenerInstancia().SaveChanges();
        }
        public List<Modelo.Gasto> ListarGastos()
        {
            return Modelo.Datos.ObtenerInstancia().Gastos.ToList();

        }

        public List<Modelo.Gasto> ListarGastosFiltrados(string Id, Modelo.Vehiculo oVehiculoF, Modelo.TipodeGasto oTipodeGastoF, string Monto, string Estado, string Descripcion, DateTime VenceDesde, DateTime VenceHasta)
        {
            List<Modelo.Gasto> Filtrado = Modelo.Datos.ObtenerInstancia().Gastos.ToList();
            if (Id.ToString() != "")
                Filtrado = Filtrado.Where(oGas => oGas.Id == Convert.ToInt32(Id)).ToList();
            if (oVehiculoF != null)
                Filtrado = Filtrado.Where(oGas => oGas.Vehiculo == oVehiculoF).ToList();
            if (oTipodeGastoF != null)
                Filtrado = Filtrado.Where(oGas => oGas.TipodeGasto == oTipodeGastoF).ToList();
            if (Monto.ToString() != "")
                Filtrado = Filtrado.Where(oGas => oGas.Monto == Convert.ToDecimal(Monto)).ToList();
            if (Estado != "")
                Filtrado = Filtrado.Where(oGas => oGas.Estado == Estado).ToList();
            if (Descripcion != "")
                Filtrado = Filtrado.Where(oGas => oGas.Descripcion.Contains(Descripcion)).ToList();
            if (VenceDesde.ToString() != null)
                Filtrado = Filtrado.Where(oGas => oGas.FechaVencimiento > VenceDesde).ToList();
            if (VenceHasta.ToString() != null)
                Filtrado = Filtrado.Where(oGas => oGas.FechaVencimiento < VenceHasta).ToList();
           
            return Filtrado;
        }

        /* public static void ActualizarGasto(Modelo.Gasto oGasto)
         {
             //Modelo.Datos.ObtenerInstancia() .Socios.MergeOption = System.Data.Objects.MergeOption.OverwriteChanges;
             Modelo.Datos.ObtenerInstancia().Refresh(System.Data.Objects.RefreshMode.StoreWins, Modelo.Datos.ObtenerInstancia().Gasto);
         }*/

        public List<Modelo.Gasto> ListarGastosMonitor()
        {
            List<Modelo.Gasto> Filtrado = Modelo.Datos.ObtenerInstancia().Gastos.OrderBy("it.FechaVencimiento ASC").ToList();
            //Filtrado = Filtrado.Where(oGas => oGas.FechaVencimiento.Date >= DateTime.Today.Date).ToList();
            Filtrado = Filtrado.Where(oGas => oGas.FechaVencimiento.Date < DateTime.Today.Date.AddDays(15)).ToList();
            Filtrado = Filtrado.Where(oGas => oGas.Estado == "PENDIENTE").ToList();

            return Filtrado;

        }


        /*
        public static IOrderedQueryable<Modelo.Gasto> ListarGastosMonitor()
        {
            var Filtrado2 = Modelo.Datos.ObtenerInstancia().Gastos.OrderBy(c => c.FechaVencimiento);
            List<Modelo.Gasto> Filtrado3 = Modelo.Datos.ObtenerInstancia().Gastos.OrderByDescending(c => c.FechaVencimiento);
            List<Modelo.Gasto> Filtrado = Modelo.Datos.ObtenerInstancia().Gastos.OrderBy("it.FechaVencimiento ASC").ToList();
            Filtrado = Filtrado.Where(oGas => oGas.FechaVencimiento.Date >= DateTime.Today.Date).ToList();
            Filtrado = Filtrado.Where(oGas => oGas.FechaVencimiento.Date < DateTime.Today.Date.AddDays(15)).ToList();
            Filtrado = Filtrado.Where(oGas => oGas.Estado == "PENDIENTE").ToList();

            return Filtrado2;

        }
         */

        public List<Modelo.Gasto> ListarGastosdeVehiculo(string Patente)
        {
            List<Modelo.Gasto> Filtrado = Modelo.Datos.ObtenerInstancia().Gastos.ToList();

            Filtrado = Filtrado.Where(oGas => oGas.Vehiculo.Patente == Patente).ToList();

                return Filtrado.OrderByDescending(x => x.Monto).ToList();
        }

    }
}
