using System;
using System.Collections.Generic;

namespace Seguridad{

    public class Retiro
    {
    public List<Retiro> CalculodeRetiro {get; set;}

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

            CalculodeRetiro = new List<Retiro>();

        }

        public void calcularRetiro()
        {
            // Retiro r = new Retiro();
            // CalculodeRetiro.Add(r);

            double MontoDisponible = 50000;

            Total = MontoDisponible - CantidadRetirar;

        }
    
    }
}