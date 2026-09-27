using System;

class InsertionSortParcial
{
    public static int[] InsertionSort(int[] vetor, int k, int ordem)
    {
        int trocas = 0;

        for (int i = 1; i < k; i++)
        {
            int chave = vetor[i];
            int j = i - 1;

            while (j >= 0 && ((ordem == 2 && vetor[j] > chave) || (ordem == 1 && vetor[j] < chave)))
            {
                vetor[j + 1] = vetor[j];
                trocas++;
                j--;
            }
            vetor[j + 1] = chave;
        }

        int[] novoVetor = new int[k];
        for (int i = 0; i < k; i++)
            novoVetor[i] = vetor[i];

        return novoVetor;
    }
}