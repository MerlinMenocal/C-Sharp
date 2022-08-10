using System;
using System.Collections.Generic;

namespace Seguridad{

    public class Retiro
    {

    public double MontoDisponible {get; set; }
    public double CantidadRetirar {get; set; }
    public DateTime Fecha {get; set; }
    public double Total {get; set; }
    
        public Retiro (double montoDisponible, double cantidadretirar, DateTime fecha, double total)
        {
            MontoDisponible = montoDisponible;
            CantidadRetirar = cantidadretirar;
            Fecha = fecha;
            Total = total;

            //double montoDisponible = 50000;
        }
    
    }
}