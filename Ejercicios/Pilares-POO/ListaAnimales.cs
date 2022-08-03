using System;
using System.Collections.Generic;

public class ListaAnimales {

    public List<Animales> ListadeAnimales {get; set;}
    public List<Mamiferos> ListadeMamiferos {get; set;} 

    public ListaAnimales()
    {
     ListadeAnimales = new List<Animales>();
     encontrarAnimales();
     
     ListadeMamiferos = new List<Mamiferos>();
     caminar();

 
    }
 
 //metodos
 private void encontrarAnimales(){

    Animales a = new Animales("Oso", "cafe", 150, "cafes", "Comida");
    ListadeAnimales.Add(a);

    Animales b = new Animales("Elefante", "Gris", 300, "Negros", "Comida");
    ListadeAnimales.Add(b);

     Animales c = new Animales("Tigre", "Negro", 140, "Negros", "Comida");
    ListadeAnimales.Add(c);
 }

                
public void listarAnimales()
    {
        Console.Clear();
        Console.WriteLine("Lista de Animales");
        Console.WriteLine("-----------------");
        Console.WriteLine("");
        foreach (var Animales in ListadeAnimales)
        {
            Console.WriteLine("Animal: " + Animales.Nombre);
            Console.WriteLine("Color: " + Animales.Color);
            Console.WriteLine("Peso en Kg: " + Animales.Peso);
            Console.WriteLine("Color de Ojos: " + Animales.ColorOjos);
            Console.WriteLine("Alimentacion: " + Animales.Comer);
            Console.WriteLine("=====================");
                 
        }

        Console.ReadLine();
    }

    private void caminar(){

    Mamiferos a = new Mamiferos("Oso", "cafe", 150, "cafes", "Comida");
    ListadeMamiferos.Add(a);

    Mamiferos b = new Mamiferos("Oso", "cafe", 150, "cafes", "Comida");
    ListadeMamiferos.Add(b);
   }

 public void listarMamiferos()
    {
        Console.Clear();
        Console.WriteLine("Lista de Animales");
        Console.WriteLine("-----------------");
        Console.WriteLine("");
        foreach (var mamiferos in ListadeMamiferos)
        {
            Console.WriteLine("Animal: " + mamiferos.Nombre);
            Console.WriteLine("Color: " + mamiferos.Color);
            Console.WriteLine("Peso en Kg: " + mamiferos.Peso);
            Console.WriteLine("Color de Ojos: " + mamiferos.ColorOjos);
            Console.WriteLine("Alimentacion: " + mamiferos.patas);
            Console.WriteLine("=====================");
                 
        }

        Console.ReadLine();
    }
}


//}