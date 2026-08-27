public static class Questao2
{
    public static int[] criarVetor()
    {
        int n;
        do 
        {
            Console.WriteLine("Informe o tamanho do Vetor: ");
            n = int.Parse(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine("Número inválido, digite um número maior que 1.");
            }
           
        } while (n < 2);
        
        return new int[n];    
    }
    public static void preencherVetor(int[] vetorQuestao2)
    {
        for (int i = 0; i < vetorQuestao2.Length; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            vetorQuestao2[i] = int.Parse(Console.ReadLine());
        }
    }   

    public static void buscador(int[] vetorQuestao2)
    {
        int maiorDiferenca = vetorQuestao2[1] - vetorQuestao2[0];
            if (maiorDiferenca < 0)
            {
                maiorDiferenca = maiorDiferenca * -1;
            }
        int vetor1 = vetorQuestao2[0];
        int vetor2 = vetorQuestao2[1];

        for (int i = 1; i < vetorQuestao2.Length - 1; i++)
        {
            int diferenca = vetorQuestao2[i + 1] - vetorQuestao2[i];
            

            if (diferenca < 0)
            {
                diferenca = diferenca * -1;
            }

            if (diferenca > maiorDiferenca)
            {
                maiorDiferenca = diferenca;
                vetor1 = vetorQuestao2[i];
                vetor2 = vetorQuestao2[i + 1];
            }
        }

        Console.WriteLine($"A maior diferença é: {maiorDiferenca}");
        Console.WriteLine($"Os valores são: {vetor1} e {vetor2}");
    }

    
}