//Identificar se um inteiro qualquer é par ou ímpar
using System;
class Progam
{
    static void Main()
    {
        int numero, resultado;

        Console.WriteLine("esse programa identifica se um numero é impar ou par.");
        Console.Write("digite um numero: ");
        numero = int.Parse(Console.ReadLine());

        resultado = numero % 2;

        if (resultado == 0)
            Console.Write("o numero e par");


        else
        {
            Console.Write("o numero e impar"); 
        }
        
        

    }
}

