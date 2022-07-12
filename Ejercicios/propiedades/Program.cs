// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Alumno a = new Alumno();
a.PrimerNombre = "Juan";
a.SegundoNombre = "Perez";

Alumno b =new Alumno();
b.Id = 2;
b.PrimerNombre = "Maria";
b.SegundoNombre = "Martinez";

Alumno c = new Alumno(3);
c.PrimerNombre = "Alicia";



Console.WriteLine(a.PrimerNombre);
Console.WriteLine(b.PrimerNombre);
Console.WriteLine(c.PrimerNombre);
