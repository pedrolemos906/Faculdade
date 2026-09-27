using System;

class Utilitarios
{
    public static int TamanhoVetor(int TamanhoVetor)
    {
        Console.WriteLine("Informe o tamanho do vetor: ");
        TamanhoVetor = int.Parse(Console.ReadLine());

        if (TamanhoVetor <= 0)
        {
            Console.WriteLine("O tamanho do vetor deve ser um número positivo.");
            Utilitarios.TamanhoVetor(TamanhoVetor);
        }
        return TamanhoVetor;
    }

    public static int TipoVetor(int TipoVetor)
    {
        Console.WriteLine("Informe o tipo do vetor: 1 - Crescente, 2 - Decrescente, 3 - Aleatório");
        TipoVetor = int.Parse(Console.ReadLine());

        if (TipoVetor < 1 || TipoVetor > 3)
        {
            Console.WriteLine("Opção inválida.");
            Utilitarios.TipoVetor(TipoVetor);
        }
        return TipoVetor;
    }

    public static int k(int k, int tamanhoVetor)
    {
        Console.WriteLine("Informe o tamanho de K: ");
        k = int.Parse(Console.ReadLine());

        if (k <= 0 || k >= tamanhoVetor)
        {
            Console.WriteLine("O tamanho de K deve ser um número positivo e menor que o tamanho do vetor.");
            Utilitarios.k(k, tamanhoVetor);
        }
        return k;
    }

    public static int Ordem(int ordem, int k)
    {
        Console.WriteLine($"Informe se os valores ordenados serão os {k} maiores ou os {k} menores elementos do vetor: 1 - Maiores, 2 - Menores");
        ordem = int.Parse(Console.ReadLine());

        if (ordem < 1 || ordem > 2)
        {
            Console.WriteLine("Opção inválida.");
            Utilitarios.Ordem(ordem, k);
        }
        return ordem;
    }

    public static int ordenador(int ordenador)
    {
        Console.WriteLine("Qual Algoritmo de Ordenação Parcial você deseja utilizar? 1 - Selection Sort, 2 - Insertion Sort, 3 - Quick Sort, 4 - Heap Sort");
        ordenador = int.Parse(Console.ReadLine());

        if (ordenador < 1 || ordenador > 4)
        {
            Console.WriteLine("Opção inválida.");
            Utilitarios.ordenador(ordenador);
        }
        return ordenador;
    }

    public static void ExibirVetor(int[] vetor)
    {
        Console.WriteLine("Vetor: ");
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i] + " ");
        }
        Console.WriteLine();
    }

    public static void PreencherVetor(int[] vetor, int tipoVetor)
    {
        Random random = new Random();

        switch (tipoVetor)
        {
            case 1:
                for (int i = 0; i < vetor.Length; i++)
                {
                    vetor[i] = i + 1;
                }
                break;

            case 2:
                for (int i = 0; i < vetor.Length; i++)
                {
                    vetor[i] = vetor.Length - i;
                }
                break;

            case 3:
                for (int i = 0; i < vetor.Length; i++)
                {
                    vetor[i] = random.Next(1, 100);
                }
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}
