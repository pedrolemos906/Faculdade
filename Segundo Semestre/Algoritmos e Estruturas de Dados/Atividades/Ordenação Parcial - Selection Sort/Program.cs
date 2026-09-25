using System;
using System.Runtime.CompilerServices;

class Program
{
    public static void selectionSort(int[] vetor)
    {
        int menor = vetor[0];
        for (int i = 0; i < vetor.Length; i++)
        {
            
            for (int j = i + 1; j < vetor.Length; j++)
            {
                if (vetor[j] < menor)
                {
                    int aux = vetor[j];
                    vetor[0] = vetor[j];
                    vetor[j] = aux;
                }
            }
        }
    }
}