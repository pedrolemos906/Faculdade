//Construa uma função recursiva que calcule o somatório de 1 até N.
using System;


class Exercicio_7
{
    static void Main()
    {
        Console.WriteLine("Somatório de 1 até N.");
        Console.WriteLine("Informe o valor de N: ");
        int n = int.Parse(Console.ReadLine());

        int resultado = somatorio(n);

        Console.WriteLine(resultado);
    }

    static int somatorio(int n)
    {
        int resultado = 0;

        if(n == 1)
        {
            resultado = 1;
        }

        else
        {
            resultado = n + somatorio(n-1);
        }

        return resultado;
    }
}