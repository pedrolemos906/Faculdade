//Calcular e escrever o peso ideal de um homem, sabendo que: Peso Ideal de pessoas de gênero masculino:  (72.7  x  altura) – 58
using System;

class Progam
{
    static void Main()
    {
        double altura, pesoideal;

        Console.WriteLine("esse programa calcula o peso ideal para um homem.");
        Console.Write("digite sua altura: ");
        altura = int.Parse(Console.ReadLine());

        pesoideal = (72.7 * altura) - 58;

        Console.WriteLine("o seu peso ideal é: " + pesoideal);

    }
}
