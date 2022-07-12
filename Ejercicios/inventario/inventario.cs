using System;

public class Inventario{

 //[,]divide cuantas columnas y filas
    string[,] productos = new string[5,3]
    {
        {"001", "IphoneX", "0"},
        {"002","Table Samsumg A8","100"},
        {"003","Laptop Dell","85"},
        {"004","CPU Dell","20"},
        {"005","Monitor HP","24"}
    };

  public Inventario (){

  }

  public void listaProductos()
  {
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


  private void movimientoInventario (string codigo, int cantidad, string tipoMovimiento){
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

  public void ingresoInventario()
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
}