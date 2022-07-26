// See https://aka.ms/new-console-template for more information

DatosdePrueba datos = new DatosdePrueba();

string opcion = "";

while (true)
{
    Console.clear();
    Console.WriteLine("Sistema de Ordenes");
    Console.WriteLine("------------------");
    Console.WriteLine("");
    Console.WriteLine("1 - Lista de Productos");
    Console.WriteLine("2 - Crear Orden");
    Console.WriteLine("3 - Lista de Clientes");
    Console.WriteLine("4 - Lista de Vendedores");
    Console.WriteLine("5 - Lista de Ordenes");
    Console.WriteLine("0 - Salir");
    opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
         datos.listarProductos();
         break;

        default:
         break;
    }


    if(opcion == "0")
    {
        break;
    }





}


