using System;
using System.Collections.Generic;

public class DatosdePrueba
{
    public List<Producto> ListadeProductos {get; set;}

    public List<Cliente> ListadeClientes {get; set;}

    public List<Vendedor> ListadeVendedores {get; set;}

    public DatosdePrueba()
    {
        ListadeProductos = new List<Producto>();
        cargarProductos();

        ListadeClientes = new List<Cliente>();
        cargarClientes();

        ListadeVendedores = new List<Vendedor>();
        cargarVendedores();
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

    private void cargarClientes()
    {
        Cliente c1 = new Cliente(1, "Juan", "9448-7544");
        ListadeClientes.Add(c1);

        Cliente c2 = new Cliente(2, "David", "9999-9999");
        ListadeClientes.Add(c2);

        Cliente c3 = new Cliente(3, "Elizabeth", "8080-4569");
        ListadeClientes.Add(c3);

    }

    private void cargarVendedores()
    {
        Vendedor v1 = new Vendedor(1, "Adrian", "V001");
        ListadeVendedores.Add(v1);

        Vendedor v2 = new Vendedor(2, "Diana", "V002");
        ListadeVendedores.Add(v2);

        Vendedor v3 = new Vendedor(3, "Alejandro", "V001");
        ListadeVendedores.Add(v3);

    }

    public void listarProductos()
    {
        Console.Clear();
        Console.WriteLine("Lista de Productos");
        Console.WriteLine("------------------");
        Console.WriteLine("");
        foreach (var producto in ListadeProductos)
        {
            Console.WriteLine(producto.Codigo + " | " + producto.Descripcion + " | " + producto.Precio);     
        }

        Console.ReadLine();
    }

    public void listarClientes()
    {
        Console.Clear();
        Console.WriteLine("Lista de Clientes");
        Console.WriteLine("-----------------");
        Console.WriteLine("");
        foreach (var cliente in ListadeClientes)
        {
            Console.WriteLine(cliente.Codigo + " | " + cliente.Nombre + " | " + cliente.Telefono);     
        }

        Console.ReadLine();
    }

    public void listarVendedores()
    {
        Console.Clear();
        Console.WriteLine("Lista de Vendedores");
        Console.WriteLine("-------------------");
        Console.WriteLine("");
        foreach (var vendedor in ListadeVendedores)
        {
            Console.WriteLine(vendedor.Codigo + " | " + vendedor.Nombre + " | " + vendedor.codigoVendedor);     
        }

        Console.ReadLine();
    }
}