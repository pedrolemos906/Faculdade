using System;
using System.Collections.Specialized;

class Exercicio_3
{
    static void Main()
    {
        Console.Write("informe o fatorial: ");
        int n = int.Parse(Console.ReadLine());

        int resultado = fatorial(n);

        Console.WriteLine(resultado);
    }

    static int fatorial(int n)
    {
        int resultado;

        if(n == 1)
        {
            resultado = 1;
        }

        else
        {
            resultado = n * fatorial(n-1);
        }

        return resultado;
    }
}