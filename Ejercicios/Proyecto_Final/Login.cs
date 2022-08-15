using System;
using System.Collections.Generic;

namespace Seguridad
{
    public class Login
    {
        private List<Usuario> usuarios{get; set;}

        public Login()
        {
            usuarios = new List<Usuario>();

            Usuario L1 = new Usuario();
            L1.pinAcceso = "8970";

            Usuario L2 = new Usuario();
            L2.pinAcceso = "9874";

            usuarios.Add(L1);
            usuarios.Add(L2);
        }
        
        public bool Validar(string pinacceso)
        {
            foreach (var usuario in usuarios){
            if(usuario.pinAcceso == pinacceso)
            {
                return true;
            }
            } 
            return false;  
        }
    }

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
        

