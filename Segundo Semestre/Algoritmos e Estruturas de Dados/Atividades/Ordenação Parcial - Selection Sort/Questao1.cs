using System;

public class Questao1
{

    public long comparacoes = 0;
    public long movimentacoes = 0;

    public void SelectionSortParcial(int[] vetor1, int k)
    {

        for (int i = 0; i < k; i++)
        {

            int menor = i;

            for (int j = i + 1; j < vetor1.Length; j++)
            {

                comparacoes++;

                if (vetor1[j] < vetor1[menor])
                {
                    menor = j;
                }
            }

            if (menor != i)
            {

                int temp = vetor1[i];
                vetor1 [i] = vetor1[menor];
                vetor1[menor] = temp;
                movimentacoes += 3;
            }
        }  
    }  
}
