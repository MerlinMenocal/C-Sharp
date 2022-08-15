using System;
using System.Collections.Generic;

namespace Seguridad{
    class Program 
    {
        Login Log = new Login();            
        string opcion = "";

        while (true)
        {
            //Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("          Por Favor Seleccione su Transacción");
            Console.WriteLine("       ________________________________________");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("       | 1 - Retirar Dinero                   |");
            Console.WriteLine("       | 2 - Ver Saldo Disponible             |");
            Console.WriteLine("       | 3 - Historial de Transacciones       |");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("       | 0 - Salir                            |");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("       ________________________________________");
            Console.ForegroundColor = ConsoleColor.White;
            opcion = Console.ReadLine();

            //Movimientos opciones = new Movimientos();
            
            switch (opcion)
            {
                // case "1":
                // opciones.verRetiro();
                // break;

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
    }
}









