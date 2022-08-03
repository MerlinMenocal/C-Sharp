// namespace Animal{

    public class Mamiferos :Animales
     {   

        public string Caminar{get; set; }



         public string Patas {get; set;}

         public Mamiferos(string nombre, string color, double peso, string colorojos, string patas)
    {
        Nombre = nombre;
        Color = color;
        Peso = peso;
        ColorOjos = colorojos;
        

     }
}