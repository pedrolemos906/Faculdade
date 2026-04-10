//Faça um programa que leia dois números reais A e B. Troque os valores entre eles e mostre o novo conteúdo de A e B:
using System;

class Program
{
    static void Main()
    {
        double a, b, aux;
        

        Console.WriteLine("esse programa troca dois numero de lugar.");
        Console.Write($"informe o valor de A: ");
        a = double.Parse(Console.ReadLine());
        Console.Write($"informe o valor de B: ");
        b = double.Parse(Console.ReadLine());

        aux = a;
        a = b;
        b = aux;

        Console.WriteLine($"A = {a}");
        Console.WriteLine($"B = {b}");

    }
}
