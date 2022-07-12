public class Producto
{   
    //3 propiedades para la clase producto
    public string Codigo {get; set; }
    public string Descripcion {get; set; }
    public int Existencia {get; set; }


    public Producto(string codigo, string descripcion, int existencia)
    {
        Codigo = codigo;
        Descripcion = descripcion;
        Existencia = existencia;

    }
}