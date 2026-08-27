public static class Questao4
{
    public static int[,] criarMatrizAleatorias()
    {
        int[,] matrizQuestao4 = new int[5, 5];
        Random random = new Random();
        for (int i = 0; i < matrizQuestao4.GetLength(0); i++)
        {
            for (int j = 0; j < matrizQuestao4.GetLength(1); j++)
            {
                matrizQuestao4[i, j] = random.Next(1, 9);
            }
        }

        return matrizQuestao4;
    }

    public static void imprimirMatriz(int[,] matrizQuestao4)
    {
        for (int i = 0; i < matrizQuestao4.GetLength(0); i++)
        {
            for (int j = 0; j < matrizQuestao4.GetLength(1); j++)
            {
                Console.Write(matrizQuestao4[i, j] + " ");
            }
            Console.WriteLine();
        }
    }


    public static bool comparadorMatriz(int[,] matriz1Questao4, int[,] matriz2Questao4)
    {
        for (int i = 0; i < matriz1Questao4.GetLength(0); i++)
        {
            for (int j = 0; j < matriz1Questao4.GetLength(1); j++)
            {
                if (matriz1Questao4[i, j] != matriz2Questao4[i, j])
                {
                    return false;
                        
                }
            }
        }
        return true;
    }

    public static void imprimirResultado(bool iguais)
    {
        if (iguais)
        {
            Console.WriteLine("As matrizes são iguais.");
        }
        else
        {
            Console.WriteLine("As matrizes são diferentes.");
        }
    }
}

