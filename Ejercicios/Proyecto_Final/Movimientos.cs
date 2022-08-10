using System;
using System.Collections.Generic;
using System.Linq;

namespace Seguridad
{
  public class Movimientos
  {
    public List<Retiro> MovimientoRetiro {get; set; }

    public Movimientos()
    {
        MovimientoRetiro = new List<Retiro>();
        hacerRetiro();
    }

    public void hacerRetiro()
    {
        double cantidadretirar = 0;

        Total = montoDisponible - cantidadretirar;

        Console.WriteLine("Ingrese la Cantidad a Retirar:");
        CantidadRetirar = double.Parse(Console.ReadLine());

        Console.WriteLine("Por favor no retires tu Tarjeta!");
        Console.WriteLine("Retiro realizado por la Cantidad de:" + CantidadRetirar);

    }

  }

}