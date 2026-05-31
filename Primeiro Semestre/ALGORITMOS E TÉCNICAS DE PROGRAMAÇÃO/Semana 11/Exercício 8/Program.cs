//8. Construa uma função que receba uma matriz quadrada de reais e dois valores inteiros, i e j, relativos à uma linha e à uma coluna, respectivamente. A função deverá verificar se a linha i da matriz é exatamente igual à coluna j. A função deverá retornar verdadeiro, se iguais; ou falso, caso contrário.
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

        for (int n = 0; n < matriz.GetLength(0); n++)
        {
            if (matriz[i,n] != matriz[n,j])
            {
                return false;
            }
        }
        

        return true;

    }
}