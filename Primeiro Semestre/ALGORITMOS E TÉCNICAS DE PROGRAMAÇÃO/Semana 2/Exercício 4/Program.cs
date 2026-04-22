//Identificar o maior entre dois números.
using System;

class Program
{
    static void Main()
    {
        double num1, num2;

        Console.WriteLine("esse programa identifica o maior entre dois numeros.");
        Console.Write("digite um numero: ");
        num1 = double.Parse(Console.ReadLine());
        Console.Write("digite outro numero: ");
        num2 = double.Parse(Console.ReadLine());

        if (num1 > num2)
            Console.WriteLine($"entre {num1} e {num2} o maior numero é {num1}.");

        if (num1 < num2)
            Console.WriteLine($"entre {num1} e {num2} o maior numero é {num2}.");

        if (num1 == num2)
            Console.WriteLine($"os numeros sao iguais.");

    }
}
