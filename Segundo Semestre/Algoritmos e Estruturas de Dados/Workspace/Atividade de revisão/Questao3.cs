public static class Questao3
{
    public static void criarMatriz(int[,] matrizQuestao3)
    {
        Random random = new Random();
        for (int i = 0; i < matrizQuestao3.GetLength(0); i++)
        {
            for (int j = 0; j < matrizQuestao3.GetLength(1); j++)
            {
                matrizQuestao3[i, j] = random.Next(1, 9);
            }
        }

        for (int i = 0; i < matrizQuestao3.GetLength(0); i++)
        {
            for (int j = 0; j < matrizQuestao3.GetLength(1); j++)
            {
                Console.Write(matrizQuestao3[i, j] + " ");
            }

            Console.WriteLine();
        }
    }

    public static void somarLinhaCinco(int[,] matrizQuestao3)
    {
        int soma = 0;
        for (int j = 0; j < matrizQuestao3.GetLength(1); j++)
        {
            soma += matrizQuestao3[4, j];
        }

        Console.WriteLine($"A soma da linha 5 é: {soma}");
    }

    public static void somarColunaQuatro(int[,] matrizQuestao3)
    {
        int soma = 0;
        for (int i = 0; i < matrizQuestao3.GetLength(0); i++)
        {
            soma += matrizQuestao3[i, 3];
        }

        Console.WriteLine($"A soma da coluna 4 é: {soma}");
    }
}