using System;

class FatorialRecursivo
{
    static void obterFatorial()
    {
        int n = int.Parse(Console.ReadLine());

        long resultado = Fatorial(n);

        Console.WriteLine(resultado);
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