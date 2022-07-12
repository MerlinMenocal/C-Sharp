using System;
using System.Collections.Generic;

public class Inventario{

    public List<Producto> ListadeProductos {get; set; }

    public Inventario()
    {
      ListadeProductos = new List<Producto>();

      Producto a = new Producto("001", "IphoneX", 0);
      Producto b = new Producto("002", "Table Samsumg A8", 5);
      Producto c = new Producto("003", "Laptop Dell", 10);
      Producto d = new Producto("004", "CPU Dell", 15);
      Producto e = new Producto("005", "Monitor HP", 5);

      listaProductos.Add(a);
      listaProductos.Add(b);
      listaProductos.Add(c);
      listaProductos.Add(d);
      listaProductos.Add(e);
    }

 public void listaProductos()
    {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Listado de Productos");
        Console.WriteLine("********************");
        Console.WriteLine("Codigo, Descripcion y Existencia");

        foreach (var producto in ListadeProductos)
        {
            Console.WriteLine(producto.Codigo + " | " + producto.Descripcion + " | " + producto.Existencia.ToString());
        }
        Console.ReadLine();
    }


 private void movimientoInventario (string codigo, int cantidad, string tipoMovimiento)
    {
        foreach (var producto in ListadeProductos) 
        {
          if (producto.Codigo == codigo)
             {
                if (tipoMovimiento == "+")
                    {
                        producto.Existencia = producto.Existencia + cantidad;
                  
                    }else{
                        producto.Existencia = producto.Existencia - cantidad;
                    }
             }

        }
   }

 public void ingresoDeInventario()
    {
        string codigo= "";
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