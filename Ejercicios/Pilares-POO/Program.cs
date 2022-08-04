
using System;
using System.Collections.Generic;

//namespace Animal{
    ListaAnimales lista = new ListaAnimales();

    
string opcion = "";

while (true)
{
    Console.Clear();
    Console.WriteLine("  Lista de Animales");
    Console.WriteLine("  -----------------");
    Console.WriteLine("");
    Console.WriteLine("1 - Animales");
    Console.WriteLine("2 - Mamiferos");
    Console.WriteLine("3 - Aves");
    Console.WriteLine("4 - peces");
    Console.WriteLine("0 - Salir");
    opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
         lista.listarAnimales();
         break;

        //  case "2":
        //  lista.caminar();
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







