﻿using System;
using System.Collections.Generic;
//using System.Movimientos.verRetiro;


namespace Seguridad{
    class Program 
    {
        

        static void Main(string[] args)
        {
            Login Log = new Login();

                string pinacceso = "";
                int contador = 1;
                
            while(true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("        CAJERO AUTOMATICO");
                Console.WriteLine("      _____________________");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
                Console.WriteLine("");
                Console.Write("      Ingrese su Token:");
                pinacceso = Console.ReadLine();

                bool resultado = Log.Validar(pinacceso);

                if(resultado == true){
                    Console.Clear();
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("             ============");
                    Console.WriteLine("            | BIENVENID@ |");
                    Console.WriteLine("             ============");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                    Console.WriteLine("Precione una tecla para continuar...");
                    Console.ReadKey();

                    
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
            Console.WriteLine("       | 3 - Historial de Transacciones       |");8
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("       | 0 - Salir                            |");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("       ________________________________________");
            Console.ForegroundColor = ConsoleColor.White;
            opcion = Console.ReadLine();

            Movimientos opciones = new Movimientos();
            
            switch (opcion)
            {
                case "1":
                opciones.verRetiro();
                break;

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

                    break;
                }else{
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("");
                    Console.WriteLine("       Código incorrecto!");
                    Console.WriteLine("           Intento " + contador + "/3");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                }

                contador ++;
                if(contador  > 3){
                    return;
                }
            }  
        }  
    }
}









