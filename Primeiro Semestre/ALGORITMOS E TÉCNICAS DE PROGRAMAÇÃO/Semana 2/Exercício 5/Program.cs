//Identificar o maior entre dois números.
using System;

class Program
{
    static void Main()
    {
        double num1, num2, num3, maior;

        Console.WriteLine("esse programa identifica o maior entre dois numeros.");
        Console.Write("digite um numero: ");
        num1 = double.Parse(Console.ReadLine());
        Console.Write("digite outro numero: ");
        num2 = double.Parse(Console.ReadLine());
        Console.Write("digite outro numero: ");
        num3 = double.Parse(Console.ReadLine());

        if (num1 > num2)
            maior = num1;
            else maior = num2;
        
        if (maior < num3)
            maior = num3;


        Console.WriteLine($"o maior numero e o {maior}");

    }
}
