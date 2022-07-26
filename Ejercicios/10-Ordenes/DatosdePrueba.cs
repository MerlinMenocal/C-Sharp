using System;
using System.Collections.Generic;

public class DatosdePrueba 
{
    public List<Producto> ListadeProductos {get; set;}

    public DatosdePrueba()
    {
        ListadeProductos = new list<Producto>();
        cargarProductos();
    }

    
    private void cargarProductos()
    {
        Producto a = new Producto(1, "Mouse", 250);
        ListadeProductos.Add(a);

        Producto b = new Producto(2, "Monitor", 4600);
        ListadeProductos.Add(b);

        Producto c = new Producto(3, "Teclado", 800);
        ListadeProductos.Add(c);

    }

    public void listarProductos()
    {
        Console.clear();
        Console.WriteLine("Lista de Productos");
        Console.WriteLine("------------------");
        Console.WriteLine("");
        foreach (var producto in ListadeProductos)
        {
            Console.WriteLine(producto.Codigo + " | " + producto.Descripcion + " | " + producto.Precio);     
        }

        Console.ReadLine();
    }
}