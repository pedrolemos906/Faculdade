public static class Questao1
{
    public static int[] criarVetor()
    {
       return new int[10];
    }
    public static void preencherVetor(int[] vetorQuestao1)
    {
        for (int i = 0; i < vetorQuestao1.Length; i++)
        {
            int num;

            do 
            {
                Console.WriteLine($"Digite o {i + 1}º número: ");
                num = int.Parse(Console.ReadLine());

                if (num <= 0)
                {
                    Console.WriteLine("Número inválido, digite um número positivo.");
                }

            } while (num <= 0);

            vetorQuestao1[i] = num;
        }
        
    }

    public static void deletarSextoElemento(int[] vetorQuestao1)
    {
        for(int i=5; i < vetorQuestao1.Length - 1; i++)
        {
            vetorQuestao1[i] = vetorQuestao1[i + 1];
        }

        vetorQuestao1[vetorQuestao1.Length - 1] = -10;

        Console.WriteLine("Valores do vetor: ");

        for (int i = 0; i < vetorQuestao1.Length; i++)
        {
            Console.WriteLine(vetorQuestao1[i]);
        }
    }
}