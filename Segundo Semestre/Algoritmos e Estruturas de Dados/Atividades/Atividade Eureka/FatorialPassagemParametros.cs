using System;

public class FatorialPassagemParametros
{
    static void obterFatorial()
    {
        int n = int.Parse(Console.ReadLine());

        long resultado = Fatorial(n);

        Console.WriteLine("FATORIAL = " + resultado);
    }

    static long Fatorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }

        return n * Fatorial(n - 1);
    }
}