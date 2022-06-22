using System;

 namespace inventario
 {
    class Program
    {
        //[,]divide cuantas columnas y filas
        static string[,] productos = new string[5,3]
        {
            {"001", "IphoneX", "0"},
            {"002","Table Samsumg A8","100"},
            {"003","Laptop Dell","85"},
            {"004","CPU Dell","20"},
            {"005","Monitor HP","24"}
        };
        
         static void listaProductos(){
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Listado de Productos");
            Console.WriteLine("********************");
            Console.WriteLine("Codigo, Descripcion y Existencia");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(productos[i,0] + " | " + productos[i, 1] + " | " + productos[i,2]);
            }
            Console.ReadLine();
         }

         static void movimientoInventario (string codigo, int cantidad, string tipoMovimiento){
            for (int i = 0; i <5; i++)
            {
                if (productos[i,0]== codigo)
                {
                    if (tipoMovimiento == "+")
                        {
                            productos[i, 2]= (Int32.Parse(productos[i,2]) + cantidad).ToString();
                            //               convierte texto a tipo entero            convierte a string
                        }else{
                            productos[i, 2]= (Int32.Parse(productos[i,2]) - cantidad).ToString();
                        }
                }

            }
   
}

        private static void ingresoInventario()
        {
            string codigoProducto = "";
            string cantidad = "";

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("INGRESO DE PRODUCTOS AL INVENTARIO");
            Console.WriteLine("**********************************");
            Console.WriteLine("Ingrese el Codigo de Producto: ");
            codigoProducto = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad del Producto: ");
            cantidad = Console.ReadLine();


            movimientoInventario(codigoProducto, Int32.Parse(cantidad), "+");
        }

        static void salidaInventario(){
            string codigoProducto= "";
            string cantidad = "";

            Console.Clear();
            Console.WriteLine("SALIDA DE PRODUCTOS DEL INVENTARIO");
            Console.WriteLine("**********************************");
            Console.Write("Ingrese el Codigo de Producto: ");
            codigoProducto = Console.ReadLine();
            Console.Write("Ingrese la cantidad del Producto: ");
            cantidad = Console.ReadLine();

            movimientoInventario(codigoProducto, Int32.Parse(cantidad), "-");
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
                      listaProductos();
                      break;
            
                    case "2":
                      ingresoInventario();
                      break;

                    case "3":
                      salidaInventario();
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