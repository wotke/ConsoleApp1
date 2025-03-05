// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Podaj pierwsza liczbe");
string buffer = Console.ReadLine();
double a = double.Parse(buffer);

Console.WriteLine("Podaj druga liczbe");
buffer = Console.ReadLine() ?? "0";
double b = double.Parse(buffer);
double result = a + b;
Console.WriteLine("Wynik dodawania liczb " + a + " i " + b + " wynosi: " + result);