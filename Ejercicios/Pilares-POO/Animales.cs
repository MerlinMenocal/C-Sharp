
using System;
using System.Collections.Generic;

public class Animales
{   
    //propiedades 
    public string Nombre {get; set; }
    public string Color {get; set; }
    public double Peso {get; set; }
    public string ColorOjos {get; set; }

    // constructor para inicializar valores
    public Animales(string nombre, string color, double peso, string colorojos)
    {
        Nombre = nombre;
        Color = color;
        Peso = peso;
        ColorOjos = colorojos;
    }

public void Comer(){
    Console.WriteLine("Este animal come");
}
}
