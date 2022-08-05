
using System;
using System.Collections.Generic;

    public class Mamiferos :Animales
     {   
        public string Patas{get; set; }

        
    public Mamiferos(string nombre, string color, double peso, string colorojos, string patas)
    {
        Nombre = nombre;
        Color = color;
        Peso = peso;
        ColorOjos = colorojos;
        Patas = patas;    
    }
    public void  Caminar(){
        Console.WriteLine("Este animal Camina");
    }
}