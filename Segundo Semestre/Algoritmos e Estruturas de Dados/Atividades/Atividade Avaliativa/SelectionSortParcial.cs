using System;

class SelectionSortParcial
{
    public static int[] SelectionSort(int[] vetor, int k, int ordem)
    {
        int trocas = 0;

        for (int i = 0; i < k; i++)
        {
            int pivo = i;
            for (int j = i + 1; j < k; j++)
            {
                if ((ordem == 2 && vetor[j] < vetor[pivo]) || (ordem == 1 && vetor[j] > vetor[pivo]))
                {
                    pivo = j;
                }
            }
            int temp = vetor[i];
            vetor[i] = vetor[pivo];
            vetor[pivo] = temp;
            trocas++;
        }

        int[] novoVetor = new int[k];
        for (int i = 0; i < k; i++)
            novoVetor[i] = vetor[i];

        return novoVetor;
    }
}