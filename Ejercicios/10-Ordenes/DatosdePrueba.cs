using System;
using System.Collections.Generic;

public class DatosdePrueba
{
    public List<Producto> ListadeProductos {get; set;}

    public List<Cliente> ListadeClientes {get; set;}

    public List<Vendedor> ListadeVendedores {get; set;}

    public List<Orden> ListaOrdenes {get; set;}

    public DatosdePrueba()
    {
        ListadeProductos = new List<Producto>();
        cargarProductos();

        ListadeClientes = new List<Cliente>();
        cargarClientes();

        ListadeVendedores = new List<Vendedor>();
        cargarVendedores();

        ListaOrdenes = new List<Orden>();

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
            Console.WriteLine(vendedor.Codigo + " | " + vendedor.Nombre + " | " + vendedor.CodigoVendedor);     
        }

        Console.ReadLine();
    }

    public void CrearOrden()
    {
        Console.Clear();
        Console.WriteLine("Creando orden");
        Console.WriteLine("-------------");
        Console.WriteLine("");

        Console.WriteLine("Ingrese el Codigo del Cliente: ");
        string codigoCliente = Console.ReadLine();

        
        Cliente cliente = ListadeClientes.Find(c => c.Codigo.ToString() == codigoCliente);
        
        if(cliente == null)
        {
            Console.WriteLine("Cliente no encontrado");
            Console.ReadLine();
            return;
        }else {
            Console.WriteLine("Cliente: " + cliente.Nombre);
            Console.WriteLine("");
        }

        Console.WriteLine("Ingrese el Codigo del Vendedor: ");
        string codigoVendedor = Console.ReadLine();

        Vendedor vendedor = ListadeVendedores.Find(v => v.Codigo.ToString() == codigoVendedor);

        if(vendedor == null)
        {
            Console.WriteLine("Vendedor no encontrado");
            Console.ReadLine();
            return;
        }else{
            Console.WriteLine("Vendedor: " + vendedor.Nombre);
            Console.WriteLine("");
        }

        int nuevoCodigo = ListaOrdenes.Count + 1;

        Orden nuevaOrden = new Orden(nuevoCodigo, DateTime.Now, "SPS" + nuevoCodigo, cliente, vendedor);
        ListaOrdenes.Add(nuevaOrden);

        while (true)
        { 
            Console.WriteLine("Ingrese el producto: ");
            string codigoProducto = Console.ReadLine();

            Producto producto = ListadeProductos.Find(p => p.Codigo.ToString() == codigoProducto);
        
                if(producto == null)
                {
                    Console.WriteLine("Producto no encontrado");
                    Console.ReadLine();
                }else{
                   Console.WriteLine("Producto agregado: " + producto.Descripcion);
                   Console.WriteLine("Precio:            " + producto.Precio); 
                   nuevaOrden.AgregarProducto(producto);
                   
                }
            Console.WriteLine("");
            Console.WriteLine("Desea continuar? s/n");
            string continuar = Console.ReadLine();
            Console.WriteLine("");
            if(continuar.ToLower() == "n")
            {
                break;
            }
        }
        Console.WriteLine("");
        Console.WriteLine("Total de la Orden es de: " + nuevaOrden.precioUnidad);
        Console.ReadLine();
    }

    public void ListarOrdenes()
    {

        Console.Clear();
        Console.WriteLine("LISTA DE ORDENES");
        Console.WriteLine("");

        foreach (var orden in ListaOrdenes)
        {
            Console.WriteLine("Fecha y Hora: " + orden.Fecha);
            Console.WriteLine("Factura No. " + orden.Codigo );
            Console.WriteLine("Cliente: " + orden.Cliente.Nombre);
            Console.WriteLine("Atendido por: " + orden.Vendedor.Nombre);
            Console.WriteLine("================================");

            Console.WriteLine("Uds." + "     " + "DESCRIPCION" + "      " + "PRECIO");
            foreach(var detalle in orden.ListaOrdenDetalle)
            {
            
                Console.WriteLine(" " + detalle.Cantidad  +  "       " + detalle.Producto.Descripcion + "            " +  detalle.Precio);
                //Console.WriteLine(

            }

                Console.WriteLine("================================");
                Console.WriteLine("");
                Console.WriteLine("                SUB-TOTAL: L." + orden.Subtotal);
                Console.WriteLine("          IMPUESTO 15%: L." + orden.Impuesto);
                Console.WriteLine("       TOTAL IMPUESTOS: L." + orden.Impuesto);
                Console.WriteLine("       TOTAL A PAGAR: L." + orden.granTotal);
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}