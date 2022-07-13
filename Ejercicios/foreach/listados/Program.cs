// See https://aka.ms/new-console-template for more information

using System.Collection.Generic;

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

