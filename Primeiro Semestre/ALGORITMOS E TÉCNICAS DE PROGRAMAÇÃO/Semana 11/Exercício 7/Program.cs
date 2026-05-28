//7. Construa uma função que receba uma matriz quadrada de reais e dois valores inteiros, i e j, relativos à uma linha e à uma coluna, respectivamente. A função deverá verificar se a soma dos valores da linha i é igual à soma dos valores da coluna j
using System;

class Program
{
    static void Main()
    {
        double[,] matriz =
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int i = 0, j = 0;

        bool ehIgual = buscarLinhasColunasIguais(matriz, i, j);

    }

    static bool buscarLinhasColunasIguais(double[,] matriz, int i, int j)
    {
        if (matriz.GetLength(0) != matriz.GetLength(1) || i >= matriz.GetLength(0) || j >= matriz.GetLength(1) || i < 0 || j < 0)
        {
            return false;
        }

        double somaI = 0;
        double somaJ = 0;

        for (int y = 0; y < matriz.GetLength(1); y++)
        {
            for (int x = 0; x < matriz.GetLength(0); x++)
            {
                if (y == j)
                {
                    somaJ = somaJ + matriz[x, y];
                }

                if (x == i)
                {
                    somaI = somaI + matriz[x, y];
                }

            }
        }

        return somaI == somaJ;

    }
}