//Construa uma função recursiva que calcule o somatório de 1 até N.
using System;


class Exercicio_8
{
    static void Main()
    {
        Console.WriteLine("Informe um número: ");
        int n = int.Parse(Console.ReadLine());

        int resultado = contCasa(n);

        Console.WriteLine(resultado);
    }

    static int contCasa(int n)
    {
        int resultado = 0;
     
        if(n < 10)
        {
            resultado = 1;
        }

        else
        {
            resultado = 1 + contCasa(n / 10);
        }

        return resultado;
    }
}