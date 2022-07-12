using System;

 namespace inventario
 {
    class Program
    {
        
         
    //     static void salidaInventario(){
    //         string codigoProducto= "";
    //         string cantidad = "";

    //         Console.Clear();
    //         Console.WriteLine("SALIDA DE PRODUCTOS DEL INVENTARIO");
    //         Console.WriteLine("**********************************");
    //         Console.WriteLine("Ingrese el Codigo de Producto: ");
    //         codigoProducto = Console.ReadLine();
    //         Console.Write("Ingrese la cantidad del Producto: ");
    //         cantidad = Console.ReadLine();

    //         movimientoInventario(codigoProducto, Int32.Parse(cantidad), "-");
    //     }

    //     static void ajustePositivo(){

    //         string codigoProducto = "";
    //         string cantidad = "";

    //         Console.Clear();
    //         Console.WriteLine();
    //         Console.WriteLine("AJUSTE POSITIVO AL INVENTARIO");
    //         Console.WriteLine("*****************************");
    //         Console.WriteLine("Ingrese el Codigo de Producto: ");
    //         codigoProducto = Console.ReadLine();
    //         Console.WriteLine("Ingrese la cantidad del Producto: ");
    //         cantidad = Console.ReadLine();


    //         movimientoInventario(codigoProducto, Int32.Parse(cantidad), "+");
    //     } 

    //    static void ajusteNegativo(){
    //         string codigoProducto= "";
    //         string cantidad = "";

    //         Console.Clear();
    //         Console.WriteLine("AJUSTES NEGATIVOS AL INVENTARIO");
    //         Console.WriteLine("*******************************");
    //         Console.WriteLine("Ingrese el Codigo de Producto: ");
    //         codigoProducto = Console.ReadLine();
    //         Console.Write("Ingrese la cantidad del Producto: ");
    //         cantidad = Console.ReadLine();

    //         movimientoInventario(codigoProducto, Int32.Parse(cantidad), "-");
    //     }



        static void Main(string[] args)
        {
            string opcion ="";
            Inventario inventario = new Inventario();


            while (true)
            {
                Console.Clear();
                Console.WriteLine("SISTEMA DE INVENTARIO");
                Console.WriteLine("*********************");
                Console.WriteLine("");
                Console.WriteLine("1- Productos");
                Console.WriteLine("2- Ingreso de Inventario");
                Console.WriteLine("3- Salida de Inventario");
                Console.WriteLine("4- Ajuste Positivo al Inventario");
                Console.WriteLine("5- Ajuste Negativo al Inventario");
                Console.WriteLine("0- Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                      inventario.listaProductos();
                      break;
            
                    case "2":
                      inventario.ingresoDeInventario();
                      break;

                    // case "3":
                    //   salidaInventario();
                    //   break;  

                    // case "4":
                    //   ajustePositivo();
                    //   break;  

                    // case "5":
                    //   ajusteNegativo();
                    //   break;  
                    
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