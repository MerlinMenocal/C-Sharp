// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;

//namespace Animal{
   // ListaAnimales lista = new ListaAnimales();

    
string opcion = "";

while (true)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("         Por Favor Seleccione su Transaccion");
    Console.WriteLine("         ___________________________________");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("");
    Console.WriteLine("1 - Retirar Dinero");
    Console.WriteLine("2 - Depósitos");
    Console.WriteLine("3 - Ver Saldo Disponible");
    Console.WriteLine("4 - Historial de Transacciones");
    Console.WriteLine("5 - Pagos");
    Console.WriteLine("6 - Recargas");
    Console.WriteLine("0 - Salir");
    opcion = Console.ReadLine();

    switch (opcion)
    {
        // case "1":
        //  lista.listarAnimales();
        //  break;

        //  case "2":
        //  lista.listarMamiferos();
        //  break;

        //   case "3":
        //   lista.listarmamiferos();
        //   break;

        //  case "3":
        //  datos.listarClientes();
        //  break;


        default:
         break;
    }


    if(opcion == "0")
    {
        break;
    }
}






