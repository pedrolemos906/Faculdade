using System;

public class Questao2
{
    public long comparacoes = 0;
    public long movimentacoes = 0;

    public void InsertionSortParcial(int[] vetor2, int k)
    {

        for (int i = 1; i < vetor2.Length; i++) 
        {

            int tmp = vetor2[i];
            movimentacoes++;

            int j = (i < k) ? i - 1 : k - 1;

            while ( (j >= 0) && (vetor2[j] > tmp) )
            {
                comparacoes++;
                
                vetor2[j + 1] = vetor2[j];
                movimentacoes++;
                j--;
            }

            vetor2[j + 1] = tmp; 
            movimentacoes++;        
        }
    }
}

