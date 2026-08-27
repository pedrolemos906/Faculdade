public static class Questao5
{
    public static int[,] criarMatriz()
    {
        int[,] matrizQuestao5 = new int[10, 10];
        
        for (int i = 0; i < matrizQuestao5.GetLength(0); i++)
        {
            for (int j = 0; j < matrizQuestao5.GetLength(1); j++)
            {
                if (i == j)
                {
                    matrizQuestao5[i, j] = 1;
                }
                else if (i < j)
                {
                    matrizQuestao5[i, j] = i + j;
                }
                else
                {
                    matrizQuestao5[i, j] = -1;
                }
                
            }
        }

        return matrizQuestao5;
    }

    public static void imprimirMatriz(int[,] matrizQuestao5)
    {
        for (int i = 0; i < matrizQuestao5.GetLength(0); i++)
        {
            for (int j = 0; j < matrizQuestao5.GetLength(1); j++)
            {
                Console.Write(matrizQuestao5[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public static void somarColuna(int[,] matrizQuestao5)
    {
        for (int j = 0; j < matrizQuestao5.GetLength(1); j++)
        {
            int coluna = j;
            int soma = 0;
            for (int i = 0; i < matrizQuestao5.GetLength(0); i++)
            {
                soma += matrizQuestao5[i, coluna];
            }

            Console.WriteLine($"Soma da coluna {coluna + 1} = {soma}");
        }
        
    }

    public static void somarTodosElementos(int[,] matrizQuestao5)
    {
        int soma = 0;
        for (int i = 0; i < matrizQuestao5.GetLength(0); i++)
        {
            for (int j = 0; j < matrizQuestao5.GetLength(1); j++)
            {
                soma += matrizQuestao5[i, j];
            }
        }

        Console.WriteLine($"Soma dos elementos da matriz = {soma}");
    }
}