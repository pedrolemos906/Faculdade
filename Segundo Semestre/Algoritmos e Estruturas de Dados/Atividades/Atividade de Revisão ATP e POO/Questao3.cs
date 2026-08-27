public static class Questao3
{
    public static int[,] criarMatriz()
    {
        int[,] matrizQuestao3 = new int[7, 7]; 
        Random sorteio = new Random();
        for (int i = 0; i < matrizQuestao3.GetLength(0); i++)
        {
            for (int j = 0; j < matrizQuestao3.GetLength(1); j++)
            {
                matrizQuestao3[i, j] = sorteio.Next(1, 9);
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
        return matrizQuestao3;
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

    public static void SomarTodosElementos(int[,] matrizQuestao3)
    {
        int soma = 0;
        for (int i = 0; i < matrizQuestao3.GetLength(0); i++)
        {
            for (int j = 0; j < matrizQuestao3.GetLength(1); j++)
            {
                soma = soma + matrizQuestao3[i, j];
            }
        }

        Console.WriteLine($"A soma de todos os elementos da matriz é: {soma}");
    }
}