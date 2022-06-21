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
                console.Clear();
                console.WriteLine("SISTEMA DE INVENTARIO");
                console.WriteLine("*********************");
                console.WriteLine("");
                console.WriteLine("1- Productos");
                console.WriteLine("2- Ingreso de Inventario");
                console.WriteLine("3- Salida de Inventario");
                console.WriteLine("0- Salir");
                opcion = console.Read();

                switch (opcion)
                {
                    case 1:
                      console.WriteLine("Productos!");
                      console.Read(); //sirve para hacer pausa
                      //listaProductos();
                      break;
                    
                    default:
                }
                
                if (opcion ==0)
                {
                    break;
                }

            }
            
        }
    }
 }