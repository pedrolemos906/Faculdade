//
using System;

class Program
{

    static double operacao(a, b, c)
    {
        double media = (a + b + c) / 3;
     
        return media;   
    }

     static double leiaReal()
    {
        Console.WriteLine("informe um valor: ");
        double x = double.Parse(Console.ReadLine());
        return x;       
    }
    
    static void Main()
    {
        double a = leiaReal;
        double b = leiaReal;
        double c = leiaReal;

        double media = operacao

        Console.WriteLine($"media = {operacao(a, b, c)}");
    }
}
