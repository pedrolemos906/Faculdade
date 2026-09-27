using System;

class QuickSortParcial
{
    public static int[] QuickSort(int[] vetor, int k, int ordem)
    {
        int trocas = 0;

        QuickSort(vetor, 0, k - 1, k, ordem, ref trocas);

        int[] novoVetor = new int[k];
        for (int i = 0; i < k; i++)
            novoVetor[i] = vetor[i];

        return novoVetor;
    }

    private static void QuickSort(int[] vetor, int esq, int dir, int k, int ordem, ref int trocas)
    {
        int i = esq;
        int j = dir;
        int pivo = vetor[(esq + dir) / 2];

        while (i <= j)
        {
            if (ordem == 2)
            {
                while (vetor[i] < pivo) i++;
                while (vetor[j] > pivo) j--;
            }
            else
            {
                while (vetor[i] > pivo) i++;
                while (vetor[j] < pivo) j--;
            }

            if (i <= j)
            {
                int aux = vetor[i];
                vetor[i] = vetor[j];
                vetor[j] = aux;
                trocas++;

                i++;
                j--;
            }
        }

        if (esq < j)
            QuickSort(vetor, esq, j, k, ordem, ref trocas);

        if (i < k && i < dir)
            QuickSort(vetor, i, dir, k, ordem, ref trocas);
    }
}