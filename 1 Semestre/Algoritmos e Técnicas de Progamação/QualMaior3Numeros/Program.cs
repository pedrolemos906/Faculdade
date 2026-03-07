using System;

class Program{
    static void Main()
    {
        double A, B, C, MAIOR;

        Console.Write("digite o 1º valor: ");
        A = double.Parse(Console.ReadLine());

        Console.Write("digite o 2º valor: ");
        B = double.Parse(Console.ReadLine());

        Console.Write("digite o 3º valor: ");
        C = double.Parse(Console.ReadLine());

        if ((A >= B) && (A >= C)) 
        {
            MAIOR = A;
        }

        else if ((B >= A) && (B >= C)) 
        {
            MAIOR = B;
        }

        else
        {
            MAIOR = C;
        }

        Console.Write("O maior número é " + MAIOR);
    }
}
