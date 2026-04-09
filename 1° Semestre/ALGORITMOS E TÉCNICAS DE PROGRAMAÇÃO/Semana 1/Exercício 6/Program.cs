//Calcular e escrever o peso ideal de uma mulher, sabendo que: Peso Ideal de pessoas de gênero feminino:  (62.1  x  altura) – 44.7
using System;

class Progam
{
    static void Main()
    {
        double altura, pesoideal;

        Console.WriteLine("esse programa calcula o peso ideal para uma mulher.");
        Console.Write("digite sua altura: ");
        altura = int.Parse(Console.ReadLine());

        pesoideal = (62.1 * altura) - 44.7;

        Console.WriteLine("o seu peso ideal é: " + pesoideal);

    }
}

