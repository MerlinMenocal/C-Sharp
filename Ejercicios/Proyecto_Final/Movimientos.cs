// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace Seguridad
// {
//   public class Movimientos
//   {
//     public List<Retiro> MovimientoRetiro {get; set; }

//     public Movimientos()
//     {
//         MovimientoRetiro = new List<Retiro>();
//         verRetiro();
//     }

//     public void verRetiro(Retiro retiro)
//     {
//       Console.Clear();
//       Console.Write("Ingresa la Cantidad a Retirar: ");
//       int CantidadRetirar =int.Parse(Console.ReadLine());

//       if(CantidadRetirar == 0){
//         Console.WriteLine("No se a ingresado una cantidad!");
//       }else{
//       Console.WriteLine("Por favor no retires tu Tarjeta!");
//       Console.WriteLine("Retiro realizado por la Cantidad de: " + Cantidadretirar);
//       }
      
//     }
    

//   }

// }