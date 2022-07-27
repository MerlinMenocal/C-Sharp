using System;
using System.Collections.Generic;


public class Orden
{

     public int Codigo {get; set; }
     public DateTime Fecha {get; set; }
     public string NumerodeOrden {get; set; }

     public Cliente Cliente {get; set; }
     public Vendedor Vendedor { get; set;}

     public List<OrdenDetalle> ListaOrdenDetalle {get; set;}

     public double precioUnidad {get; set; }
     public double Subtotal {get; set; }
     public double Impuesto {get; set; }
     public double granTotal {get; set; }


        public Orden(int codigo, DateTime fecha, string numeroOrden, Cliente cliente, Vendedor vendedor)
        {
            Codigo = codigo;
            Fecha = fecha;
            NumerodeOrden = numeroOrden;
            Cliente = cliente;
            Vendedor = vendedor;
            ListaOrdenDetalle = new List<OrdenDetalle>();

        }

        public void AgregarProducto(Producto producto)
        {
            int nuevoCodigo =ListaOrdenDetalle.Count + 1;
            int cantidad = 1;
            double impuesto = 0.15;
            
           OrdenDetalle  o = new OrdenDetalle(nuevoCodigo, 1, producto);
           ListaOrdenDetalle.Add(o);

            //int i = (int)Math.Round(Impuesto);

           Math.Round(Impuesto, 2).ToString("#.#0");
           precioUnidad += cantidad * producto.Precio;
           Subtotal += precioUnidad;
           Impuesto = impuesto * Subtotal;
           granTotal  = Subtotal + Impuesto;



        }
   

}

