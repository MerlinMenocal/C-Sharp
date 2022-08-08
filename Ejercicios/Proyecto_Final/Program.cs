using System;
using System.Collections.Generic;

//**************************************************************
//INGRESO Y AUTENTICACION
namespace menu{

class Program
{
    static void Main(string[] args)
    {
            string pinacceso = "";
            int contador = 1;
            Login Log = new Login();

        while(true)
        {
            Console.Clear();

            Console.WriteLine("      CAJERO AUTOMATICO");
            Console.WriteLine("");
            Console.WriteLine("Ingrese el Token: ");
            pinacceso = Console.ReadLine();

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
    }  
}
}









