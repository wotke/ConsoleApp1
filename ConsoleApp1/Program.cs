﻿// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Podaj pierwsza liczbe");
string buffer = Console.ReadLine();
double a = double.Parse(buffer);

Console.WriteLine("Podaj druga liczbe");
buffer = Console.ReadLine() ?? "0";
double b = double.Parse(buffer);

Console.WriteLine("Wybierz rodzaj dzialania: ");
buffer = Console.ReadLine() ?? "0";
char operation = buffer[0];
    double result;
switch(operation)
{
    case '+':
        result = a + b;
        break;
    case '-':
        result = a - b;
        break;
    case '*':
        result = a * b;
        break;
    case '/':
        result = a / b;
        break;
    default:
        result = 0;
        break;
}
Console.WriteLine("Wynik dodawania liczb " + a + " i " + b + " wynosi: " + result);