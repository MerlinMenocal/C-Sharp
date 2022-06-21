using System;

 namespace inventario
 {
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("SISTEMA DE INVENTARIO");
                Console.WriteLine("*********************");
                Console.WriteLine("");
                Console.WriteLine("1- Productos");
                Console.WriteLine("2- Ingreso de Inventario");
                Console.WriteLine("3- Salida de Inventario");
                Console.WriteLine("0- Salir");
                opcion = Console.Read();

                switch (opcion)
                {
                    case 1:
                      Console.WriteLine("Productos!");
                      Console.Read(); //sirve para hacer pausa
                      //listaProductos();
                      break;
                    
                    default:
                    break;
                }

                if (opcion ==0)
                {
                    break;
                }

            }
            
        }
    }
 }