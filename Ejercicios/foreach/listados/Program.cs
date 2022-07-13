// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;

List<string> nombres = new List<string>();
nombres.Add("Juan");
nombres.Add("Pedro");
nombres.Add("Elizabeth");

foreach (var nombre in nombres)
{
    Console.WriteLine(nombre);
}

List<int> numeros = new List<int>();
numeros.Add(10);
numeros.Add(1);
numeros.Add(5);

foreach (var numero in numeros)
{
    Console.WriteLine(numero);
}

List<alumno> alumnos = new List<Alumno>();
Alumno a= new alumno(1, "Pedro");
Alumno b= new alumno(2, "Eduar");
Alumno c= new alumno(3, "Elias");

alumnos.Add(a);
alumnos.Add(b);
alumnos.Add(c);

foreach (var alumno in alumnos ){
    Console.WriteLine(alumno.Nombre);
}


