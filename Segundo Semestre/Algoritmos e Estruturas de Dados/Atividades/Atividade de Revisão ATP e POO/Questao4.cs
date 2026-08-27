public static class Questao4
{
    public static void criarMatrizAleatorias(int[,] matrizQuestao4)
    {
        Random random = new Random();
        for (int i = 0; i < matrizQuestao4.GetLength(0); i++)
        {
            for (int j = 0; j < matrizQuestao4.GetLength(1); j++)
            {
                matrizQuestao4[i, j] = random.Next(1, 9);
            }
        }

        for (int i = 0; i < matrizQuestao4.GetLength(0); i++)
        {
            for (int j = 0; j < matrizQuestao4.GetLength(1); j++)
            {
                Console.Write(matrizQuestao4[i, j] + " ");
            }

            Console.WriteLine();
        }
    }

    public static void criarMatriz(int[,] matrizQuestao4)
    {
    
        for (int i = 0; i < matrizQuestao4.GetLength(0); i++)
        {
            for (int j = 0; j < matrizQuestao4.GetLength(1); j++)
            {
                Console.WriteLine($"Informe o valor da posição [{i}, {j}]: ");
                matrizQuestao4[i, j] = int.Parse(Console.ReadLine());   
            }
        }

        for (int i = 0; i < matrizQuestao4.GetLength(0); i++)
        {
            for (int j = 0; j < matrizQuestao4.GetLength(1); j++)
            {
                Console.Write(matrizQuestao4[i, j] + " ");
            }

            Console.WriteLine();
        }
    }

    public static void comparadorMatriz(int[,] matrizQuestao4, int[,] matrizQuestao4_2)
    {
        bool iguais = true;
        for (int i = 0; i < matrizQuestao4.GetLength(0); i++)
        {
            for (int j = 0; j < matrizQuestao4.GetLength(1); j++)
            {
                if (matrizQuestao4[i, j] != matrizQuestao4_2[i, j])
                {
                    iguais = false;
                    break;    
                }
            }
        }      
    }

}

