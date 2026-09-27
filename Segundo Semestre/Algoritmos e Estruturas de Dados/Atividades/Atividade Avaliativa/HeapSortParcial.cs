using System;

class HeapSortParcial
{
    public static int[] HeapSort(int[] vetor, int k, int ordem)
    {
        int n = vetor.Length;
        int trocas = 0;

        ConstruirHeap(vetor, n, ordem, ref trocas);

        int tamanhoAtual = n;
        for (int aux = 0; aux < k; aux++)
        {
            int temp = vetor[0];
            vetor[0] = vetor[tamanhoAtual - 1];
            vetor[tamanhoAtual - 1] = temp;
            trocas++;

            tamanhoAtual--;
            Ajustar(vetor, tamanhoAtual, 0, ordem, ref trocas);
        }

        int[] novoVetor = new int[k];
        for (int i = 0; i < k; i++)
            novoVetor[i] = vetor[n - k + i];

        return novoVetor;
    }

    private static void ConstruirHeap(int[] vetor, int n, int ordem, ref int trocas)
    {
        int ultimoPai = n / 2 - 1;
        for (int i = ultimoPai; i >= 0; i--)
            Ajustar(vetor, n, i, ordem, ref trocas);
    }

    private static void Ajustar(int[] vetor, int tamanho, int raiz, int ordem, ref int trocas)
    {
        int maiorOuMenor = raiz;
        int esquerda = 2 * raiz + 1;
        int direita = 2 * raiz + 2;

        if (esquerda < tamanho)
        {
            if (ordem == 2 && vetor[esquerda] > vetor[maiorOuMenor]) maiorOuMenor = esquerda;
            if (ordem == 1 && vetor[esquerda] < vetor[maiorOuMenor]) maiorOuMenor = esquerda;
        }

        if (direita < tamanho)
        {
            if (ordem == 2 && vetor[direita] > vetor[maiorOuMenor]) maiorOuMenor = direita;
            if (ordem == 1 && vetor[direita] < vetor[maiorOuMenor]) maiorOuMenor = direita;
        }

        if (maiorOuMenor != raiz)
        {
            int temp = vetor[raiz];
            vetor[raiz] = vetor[maiorOuMenor];
            vetor[maiorOuMenor] = temp;
            trocas++;

            Ajustar(vetor, tamanho, maiorOuMenor, ordem, ref trocas);
        }
    }
}