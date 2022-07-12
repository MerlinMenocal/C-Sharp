// See https://aka.ms/new-console-template for more information


//instancias
Alumno a = new Alumno(1, "Juan", "Perez");
Alumno b = new Alumno(2, "Maria", "Coto");

a.InactivarAlumno();

Console.WriteLine(a.nombreCompleto());
Console.WriteLine(b.nombreCompleto());

