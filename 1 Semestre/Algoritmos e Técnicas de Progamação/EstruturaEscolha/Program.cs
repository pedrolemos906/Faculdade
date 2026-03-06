using System;

class Program{
    static void Main()
    {
        double A, B, MAIOR;

        Console.Write("digite o 1º valor: ");
        A = double.Parse(Console.ReadLine());

        Console.Write("digite o 1º valor: ");
        B = double.Parse(Console.ReadLine());

        if (A > B) MAIOR = A;

        else
        {
            MAIOR = B;
        }

        Console.Write("O maior número é o " + MAIOR);
    }
}