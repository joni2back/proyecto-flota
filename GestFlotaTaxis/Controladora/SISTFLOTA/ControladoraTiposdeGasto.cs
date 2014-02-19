using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora
{
    public class ControladoraTiposdeGasto
    {
        public List<Modelo.TipodeGasto> ListarTiposdeGasto()
        {

            return Modelo.Datos.ObtenerInstancia().TiposdeGasto.OrderBy(t => t.Descripcion).ToList();

        }

        public void CargarTiposdeGasto()
        {
            List<Modelo.TipodeGasto> Lista = Modelo.Datos.ObtenerInstancia().TiposdeGasto.ToList();
            if (Lista.Count == 0)
            {
                Modelo.TipodeGasto a = new Modelo.TipodeGasto();
                a.Descripcion = "INFRACCION";
                Modelo.Datos.ObtenerInstancia().TiposdeGasto.AddObject(a);
                Modelo.TipodeGasto b = new Modelo.TipodeGasto();
                b.Descripcion = "TALLER";
                Modelo.Datos.ObtenerInstancia().TiposdeGasto.AddObject(b);
                Modelo.TipodeGasto c = new Modelo.TipodeGasto();
                c.Descripcion = "PATENTE";
                Modelo.Datos.ObtenerInstancia().TiposdeGasto.AddObject(c);
                Modelo.TipodeGasto d = new Modelo.TipodeGasto();
                d.Descripcion = "SEGURO";
                Modelo.Datos.ObtenerInstancia().TiposdeGasto.AddObject(d);
                Modelo.TipodeGasto e = new Modelo.TipodeGasto();
                e.Descripcion = "CUBIERTAS";
                Modelo.Datos.ObtenerInstancia().TiposdeGasto.AddObject(e);

                Modelo.Datos.ObtenerInstancia().SaveChanges();

                Modelo.Vehiculo f = new Modelo.Vehiculo();
                f.Patente = "APD-463";
                f.Marca = "FIAT";
                f.Modelo = "DUNA";
                f.PatenteTaxi = 927;
                f.Año = 1996;
                f.Color = "BLANCO";
                f.Kilometraje = 130000;
                Modelo.Datos.ObtenerInstancia().Vehiculos.AddObject(f);

                Modelo.Gasto g = new Modelo.Gasto();
                g.Descripcion = "Cambio de 4 neumaticos";
                g.Estado = "PENDIENTE";
                g.FechaVencimiento = DateTime.Today;
                g.Monto = 450;
                g.Vehiculo = f; // Modelo.Datos.ObtenerInstancia().Vehiculos.FirstOrDefault();
                g.TipodeGasto = e; // Modelo.Datos.ObtenerInstancia().TiposdeGasto.FirstOrDefault(); = 
                g.Usuario = "Sistema";
                g.FechayHora = DateTime.Now;
                g.Operacion = "ALTA";
                Modelo.Datos.ObtenerInstancia().Gastos.AddObject(g);
                            
                Modelo.Datos.ObtenerInstancia().SaveChanges();
            }



            

             
        }
    }
}
