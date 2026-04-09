// Calcular e escrever o número de dias vividos até o último aniversário. Ignore os anos bissextos.
using System;
class Progam
{
    static void Main()
    {
        int idade, diasVividos;

        Console.WriteLine("esse programa calcula o numero de dias vividos.");
        Console.Write("digite sua idade: ");
        idade = int.Parse(Console.ReadLine());

        diasVividos = idade * 365;

        Console.Write("o numero de dias vividos é: " + diasVividos);

    }
}
