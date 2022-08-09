using System;
using System.Collections.Generic;

namespace Seguridad{

    public class Retiro{

    public double MontoDisponible {get; set; }
    public double CantidadRetirar {get; set; }
    public DateTime Fecha {get; set; }
    public double Total {get; set; }


    public Retiro(double montoDisponible, double cantidadretirar, DateTime fecha, double total)
    {
        MontoDisponible = montoDisponible;
        CantidadRetirar = cantidadretirar;
        Fecha = fecha;
        Total = total;
    }

    public void ImprimirRetiro()
    {
        double montoDisponible = 50000;
        double cantidadretirar = 0;
            
        Total = montoDisponible - cantidadretirar;

        Console.WriteLine("Ingrese la Cantidad a Retirar:");
        CantidadRetirar = double.Parse(Console.ReadLine());

                    Console.WriteLine("Por favor no retires tu Tarjeta!");
                    Console.WriteLine("Retiro realizado por la Cantidad de:" + CantidadRetirar);
    }
    }
}