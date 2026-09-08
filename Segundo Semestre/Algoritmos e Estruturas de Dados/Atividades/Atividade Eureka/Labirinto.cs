using System;

public class Labirinto
{
    static int N, M;
    static char[,] grid;
    static long[,] memo;

    public void criarLabirinto()
    {
        string[] primeiraLinha = Console.ReadLine().Split(' ');
        N = int.Parse(primeiraLinha[0]);
        M = int.Parse(primeiraLinha[1]);

        grid = new char[N, M];
        for (int i = 0; i < N; i++)
        {
            string linha = Console.ReadLine();
            for (int j = 0; j < M; j++)
                grid[i, j] = linha[j];
        }

        memo = new long[N, M];
        for (int i = 0; i < N; i++)
            for (int j = 0; j < M; j++)
                memo[i, j] = -1; 

        Console.WriteLine(Contar(0, 0));
    }

    public long Contar(int i, int j)
    {
        if (i >= N || j >= M || grid[i, j] == '#')
            return 0;

        if (i == N - 1 && j == M - 1)
            return 1;

        if (memo[i, j] != -1)
            return memo[i, j];

        memo[i, j] = Contar(i + 1, j) + Contar(i, j + 1);
        return memo[i, j];
    }
}