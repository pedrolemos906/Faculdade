using System;

class Program
{
    static void Main(string[] args)
    {
        //Valor de N
        Console.WriteLine("Escolha o tamanho de N:");
        Console.WriteLine("1 - N = 1000");
        Console.WriteLine("2 - N = 10000");
        int opcaoN = int.Parse(Console.ReadLine());

        int n;
        switch (opcaoN)
        {
            case 1:
                n = 1000;
                break;
            case 2:
                n = 10000;
                break;
            default:
                Console.WriteLine("Opcao invalida, usando N = 1000");
                n = 1000;
                break;
        }

        //Valor de K
        Console.WriteLine("Escolha o valor de K:");
        Console.WriteLine("1 - K = 10");
        Console.WriteLine("2 - K = 100");
        Console.WriteLine("3 - K = 500");
        int opcaoK = int.Parse(Console.ReadLine());

        int k;
        switch (opcaoK)
        {
            case 1:
                k = 10;
                break;
            case 2:
                k = 100;
                break;
            case 3:
                k = 500;
                break;
            default:
                Console.WriteLine("Opcao invalida, usando K = 10");
                k = 10;
                break;
        }

        //Vetor
        Console.WriteLine("Escolha o tipo de entrada:");
        Console.WriteLine("1 - Ordenado");
        Console.WriteLine("2 - Inverso");
        Console.WriteLine("3 - Aleatorio");
        int opcaoTipo = int.Parse(Console.ReadLine());

        
        int[] vetor1;
        int[] vetor2;

        switch (opcaoTipo)
        {
            case 1:
                vetor1 = GerarOrdenado(n);
                vetor2 = GerarOrdenado(n);
                break;
            case 2:
                vetor1 = GerarInverso(n);
                vetor2 = GerarInverso(n);
                break;
            case 3:
                vetor1 = GerarAleatorio(n);
                vetor2 = GerarAleatorio(n);
                break;
            default:
                Console.WriteLine("Opcao invalida, usando Aleatorio");
                vetor1 = GerarAleatorio(n);
                vetor2 = GerarAleatorio(n);
                break;
        }

        //Questão 1
        Console.WriteLine();
        Console.WriteLine("Questao 1 - Selection Sort Parcial");
        Questao1 questao1 = new Questao1();
        questao1.SelectionSortParcial(vetor1, k);

        Console.WriteLine($"Comparacoes: {questao1.comparacoes}");
        Console.WriteLine($"Movimentacoes: {questao1.movimentacoes}");

        //Questão 2 
        Console.WriteLine();
        Console.WriteLine("Questao 2 - Insertion Sort Parcial");
        Questao2 questao2 = new Questao2();
        questao2.InsertionSortParcial(vetor2, k);

        Console.WriteLine($"Comparacoes: {questao2.comparacoes}");
        Console.WriteLine($"Movimentacoes: {questao2.movimentacoes}");
    }

    static int[] GerarOrdenado(int n)
    {
        int[] vetor = new int[n];
        for (int i = 0; i < n; i++)
            vetor[i] = i + 1;
        return vetor;
    }

    static int[] GerarInverso(int n)
    {
        int[] vetor = new int[n];
        for (int i = 0; i < n; i++)
            vetor[i] = n - i;
        return vetor;
    }

    static int[] GerarAleatorio(int n)
    {
        int[] vetor = new int[n];
        Random random = new Random();
        for (int i = 0; i < n; i++)
            vetor[i] = random.Next(1, n + 1);
        return vetor;
    }
}
