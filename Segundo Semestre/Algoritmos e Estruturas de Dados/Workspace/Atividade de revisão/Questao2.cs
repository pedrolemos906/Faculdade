public static class Questao2
{
    public static void criarVetor()
    {
        Console.WriteLine("Questão 2");
        Console.WriteLine("Informe o tamanho do Vetor: ");
        int n = int.Parse(Console.ReadLine());
        int[] vetor = new int[n];

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine($"Informe o {i + 1}º valor do vetor: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }
        

        int maiorDiferenca = vetor[1] - vetor[0];
        int vetor1 = vetor[0];
        int vetor2 = vetor[1];

        for (int i = 1; i < vetor.Length - 1; i++)
        {
            int diferenca = vetor[i + 1] - vetor[i];
            

            if (diferenca < 0)
            {
                diferenca = diferenca * -1;
            }

            if (diferenca > maiorDiferenca)
            {
                maiorDiferenca = diferenca;
                vetor1 = vetor[i];
                vetor2 = vetor[i + 1];
            }
        }

        Console.WriteLine($"A maior diferença é: {maiorDiferenca}");
        Console.WriteLine($"Os valores são: {vetor1} e {vetor2}");

    }
}