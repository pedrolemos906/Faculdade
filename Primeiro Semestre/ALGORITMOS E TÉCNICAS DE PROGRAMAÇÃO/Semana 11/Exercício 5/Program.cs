//5. Construa uma função que receba duas matrizes de reais de uma mesma dimensão. A função deverá gerar o número de ocorrências de valores iguais em uma mesma posição.
using System;

class Program
{
    static void Main()
    {
        double[,] matriz1 =
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
        
        double[,] matriz2 =
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int qtIguais = buscarIguais(matriz1, matriz2);

    }

    static int buscarIguais(double[,] matriz1, double[,] matriz2)
    {
        if(matriz1 == null || matriz2 == null|| matriz1.Length == 0 || matriz2.Length == 0 || matriz1.GetLength(0) != matriz2.GetLength(0) || matriz1.GetLength(1) != matriz2.GetLength(1) )
        {
            return 0;
        }
        int contIguais = 0;

            for(int j = 0; j < matriz1.GetLength(1); j++)
            {
                for(int i = 0; i < matriz1.GetLength(0); i++)
                {
                    if(matriz1[i, j] == matriz2[i,j])
                    {
                        contIguais = contIguais + 1;
                    }

                }
            }  
        
        return contIguais;
        
    }
}  