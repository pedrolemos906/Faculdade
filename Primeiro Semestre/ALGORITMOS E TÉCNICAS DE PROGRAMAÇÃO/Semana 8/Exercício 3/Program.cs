//Faça umprograma que receba as três notas, calcule e mostre a média ponderada e o conceito que segue a tabela:
using System;

class Program
{
    static void Main()
    {
        int numero, soma;

        Console.WriteLine("esse programa mostra a soma dos numeros informados.");
        Console.WriteLine("digite um valor; ");

        numero = int.Parse(Console.ReadLine());
        
        while (numero != 0)
        {
            soma = soma + numero;
            Console.WriteLine("digite outro valor: ");
            numero = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"soma: {soma}");

       
    }
}
