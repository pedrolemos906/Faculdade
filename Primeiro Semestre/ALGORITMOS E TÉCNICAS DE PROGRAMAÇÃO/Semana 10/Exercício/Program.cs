using System;
class Program
{
    static void Main()
    {
        
        double[] notas = new double[5];

        leiaNotas(notas);
        
        double media = mediaNotas(notas);
    }

    static void leiaNotas(double[] n)
    {
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"digite a {i+1}º nota: ");
            n[i] = double.Parse(Console.ReadLine());


        }
    }

    static double somaNotas(double[] a)
    {
        double soma = 0;
        for (int i = 0; i < 5; i++)
        {
            soma = soma + a[i];
        }
        return soma;
    }


    static double mediaNotas(double[] v)
    {
        return somaNotas(v) / 5;
    }

}