using System;
using System.Collections.Specialized;

class Exercicio_4
{
    static void Main()
    {
        Console.Write("informe o termo: ");
        int n = int.Parse(Console.ReadLine());
        

        int resultado = fibo(n);

        Console.WriteLine(resultado);
    }

    static int fibo(int n)
    {
        int resultado;

        if (n <= 2)
        {
            resultado = n - 1;
        }

        else
        {
            resultado = fibo(n - 1) + fibo(n-2);
        }

        return resultado;
    
    }
}