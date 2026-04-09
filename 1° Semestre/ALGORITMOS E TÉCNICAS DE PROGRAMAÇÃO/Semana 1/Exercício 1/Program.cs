// Calcular e escrever a soma de dois números reais lidos.
using System;
class Progam
{
    static void Main()
    {
        double a, b, r;

        Console.WriteLine("esse programa soma doi algarismos.");
        Console.Write("digite o primeiro algarismo: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("digite o segundo algarismo: ");
        b = double.Parse(Console.ReadLine());

        r = a + b;

        Console.Write("a soma dos dois algarismos é: " + r);

    }
}

