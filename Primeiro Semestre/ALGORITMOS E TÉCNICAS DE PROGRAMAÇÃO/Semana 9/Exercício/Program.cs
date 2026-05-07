//Faça umprograma que leia dois numeors e diga qual é o maior:
using System;

class Program
{
    static void Main()
    {
       Console.WriteLine("esse programa identificar o maior entre dois numeros");
        double x = leiaReal();
        double y = leiaReal();
        Console.Write("maior =" + maior);
    }

    static double leiaReal()
    {
        double n;
        Console.Write("digite valor: ");
        n = double.Parse(Console.ReadLine());
        return n;
    }

    static double maior(double a, double b)
    {
        double maior = a;
        if( a < b);
        return b;
    }
   


}
