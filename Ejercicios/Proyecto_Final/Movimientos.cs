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
        verRetiro();
    }

    public void verRetiro()
    {
      Console.Clear();
      Console.Write("Ingresa la Cantidad a Retirar: ");
      double CantidadRetirar = double.Parse(Console.ReadLine());

      Console.WriteLine("Por favor no retires tu Tarjeta!");
      Console.WriteLine("Retiro realizado por la Cantidad de:" + CantidadRetirar);
      
    }

  }

}