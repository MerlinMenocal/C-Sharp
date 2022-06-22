using System;

 namespace inventario
 {
    class Program
    {
        //[,]divide cuantas columnas y filas
        string[,] productos = new string[5,3]
        {
            {"001", "IphoneX", "0"},
            {"002","Table Samsumg A8","100"},
            {"003","Laptop Dell","85"},
            {"004","CPU Dell","20"},
            {"005","Monitor HP","24"}
        };
        
         void listaProductos(){
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Listado de Productos");
            Console.WriteLine("********************");
            Console.WriteLine("Codigo, Descripcion y Existencia");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(productos[i,0] + " | " + productos[i, 1] + " | " + productos[i,2]);
            }
         }

        static void Main(string[] args)
        {
            string opcion ="";

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
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                      Console.WriteLine("Productos!");
                      Console.Read(); //sirve para hacer pausa
                      //listaProductos();
                      break;
                    
                    default:
                    break;
                }

                if (opcion =="")
                {
                    break;
                }

            }
            
        }
    }
 }