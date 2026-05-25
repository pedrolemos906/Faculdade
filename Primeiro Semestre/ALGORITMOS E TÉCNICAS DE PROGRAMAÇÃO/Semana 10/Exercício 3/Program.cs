//3. Construa uma função que receba um arranjo de reais. A função deverá trocar o primeiro elemento do arranjo com o último.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Esse programa troca o primeiro elemento do arranjo pelo último.");
        double [] valores = {10,20,30,40,50};

        printVetor(valores);

        trocaValores(valores);

        printVetor(valores);
    }

    static void trocaValores(double[] valores)
    {

        double aux = valores[0];
        double ultimo = valores[valores.Length - 1];        

        valores[0] = ultimo;
        valores[valores.Length - 1] = aux;
    }

    static void printVetor(double[] valores)
    {
        for (int x = 0; x < valores.Length; x++)
        {
            Console.Write($"{valores[x]} ");
        }
        Console.WriteLine();
    }
}