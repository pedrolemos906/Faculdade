//4. Construa uma função que receba um arranjo de reais. A função deverá trocar dois elementos de lugar. As duas posições deverão também ser parametrizadas.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Esse programa troca dois números de um vetor de lugar.");
        double [] valores = {1,2,3,4,5};
        printVetor(valores);
        Console.Write("Escolha o primeiro número: ");
        int posicao1 = int.Parse(Console.ReadLine());
        Console.Write("Escolha o segundo número: ");
        int posicao2 = int.Parse(Console.ReadLine());
        

        trocaValores(valores, posicao1, posicao2);

        printVetor(valores);
    }

    static void trocaValores(double[] valores, int posicao1, int posicao2)
    {
        double num1 = valores[posicao1 - 1];
        double num2 = valores[posicao2 - 1];       

        double aux = num1; 
        valores[posicao1 - 1] = num2;
        valores[posicao2 - 1] = aux;
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