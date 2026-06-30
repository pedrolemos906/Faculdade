using System;
using System.Collections.Specialized;

class Exercicio_4
{
    static void Main()
    {
        Console.Write("informe a base: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("informe o expoente: ");
        int e = int.Parse(Console.ReadLine());

        int resultado = potencia(b,e);

        Console.WriteLine(resultado);
    }

    static int potencia(int b, int e)
    {
        int resultado;

        if (e < 1)
        {
            resultado = 1;
        }

        else
        {
            resultado = b * potencia(b, e - 1);
        }

        return resultado;
    
    }
}