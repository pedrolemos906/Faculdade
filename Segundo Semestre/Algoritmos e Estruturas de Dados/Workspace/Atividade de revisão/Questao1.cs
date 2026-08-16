public static class Questao1
{
    public static void criarVetor(int[] vetor)
    {
        Console.WriteLine("Questão 1");
        

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine($"Informe o {i + 1}º valor do vetor: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }
        
    }

    public static void deletarSextoElemento(int[] vetor)
    {
        for(int i=5; i < vetor.Length - 1; i++)
        {
            vetor[i] = vetor[i + 1];
        }

        vetor[vetor.Length - 1] = -10;

        Console.WriteLine("Valores do vetor: ");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine(vetor[i]);
        }
    }
}