using System;
using System.Collections.Generic;

//**************************************************************
//INGRESO Y AUTENTICACION
namespace menu{

    string pinAcceso = "";
    int contador = 1;
    Login Log = new Login();

    while(true)
    {
        Console.Clear();

        Console.WriteLine("      CAJERO AUTOMATICO");
        Console.WriteLine("");
        Console.WriteLine("Ingrese el Token: ");
        pinAcceso = Console.ReadLine();

        bool resultado = Log.Validar(pinacceso);

        if(resultado == true){
            break;
        }else{
            Console.WriteLine("Código incorrecto!");
            Console.WriteLine("Intento + contador /3");
            Console.ReadKey();
        }

        contador ++;
        if(contador  > 3){
            return;
        }
    }
//**************************************************************    

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
        Console.WriteLine("       | 2 - Depósitos                        |");
        Console.WriteLine("       | 3 - Ver Saldo Disponible             |");
        Console.WriteLine("       | 4 - Historial de Transacciones       |");
        Console.WriteLine("       | 5 - Pagos                            |");
        Console.WriteLine("       | 6 - Recargas                         |");
        Console.ForegroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("       | 0 - Salir                            |");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("       ________________________________________");
        Console.ForegroundColor = ConsoleColor.White;
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
}









