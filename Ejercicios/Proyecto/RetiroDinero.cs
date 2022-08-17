// using System;
// using System.Collections.Generic;

// public class Retiro
// {
//     public int Saldo {get; set; }
//     public DateTime Fecha {get; set; }
//     public int CantidadRetirar {get; set; }
//     public int SaldoDisponible {get; set; }
//     public int Total {get; set; }

// }

// public Retiro(int saldo, DateTime fecha, int cantidadRetirar, int saldoDisponible, int total)
// {
// Saldo = saldo;
// Fecha = fecha;
// CantidadRetirar = cantidadRetirar;
// SaldoDisponible = saldoDisponible;
// Total = total;
// }

// public void calcularRetiro(Retiro saldo, Retiro fecha, Retiro cantidadRetirar)
// {
//     saldo = 50000;

//     Total = cantidadRetirar - saldo;

// }

// public void verRetiro(cantidadRetirar, saldo, Total, fecha)
// {
//     Console.Clear();
//     Console.Write("Ingresa la Cantidad a Retirar: ");
//     int CantidadRetirar =int.Parse(Console.ReadLine());

//     if(CantidadRetirar == 0){
//     Console.WriteLine("No se a ingresado una cantidad!");
//     }else{
//     Console.WriteLine("Por favor no retires tu Tarjeta!");
//     Console.WriteLine("Retiro realizado por la Cantidad de: " + Cantidadretirar);
// }

// }