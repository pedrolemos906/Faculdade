//Faça um programa que leia três valores e ordená-los. Escrever os números na ordem cresente. 
using System;
class Progam
{
    static void Main()
    {
        double a, b, c, posicao1, posicao2, posicao3;

        Console.WriteLine("esse programa coloca em ordem crescente os valores informados.");
        Console.Write("informe o primeiro valor: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("informe o segundo valor: ");
        b = double.Parse(Console.ReadLine());
        Console.Write("informe o terceiro valor: ");
        c = double.Parse(Console.ReadLine());

        if (a > b && a > c)
            posicao3 = a;
        else if (b > a && b > c)
            posicao3 = b;
        else posicao3 = c;

        if (a < b && a < c)
            posicao1 = a;
        else if (b < a && b < c)
            posicao1 = b;
        else posicao1 = c;

        if (a > posicao1 && a < posicao3)
            posicao2 = a;
        else if (b > posicao1 && b <posicao3)
            posicao2 = b;
        else posicao2 = c;


        Console.WriteLine($"{posicao1}, {posicao2}, {posicao3}");

    }
}

