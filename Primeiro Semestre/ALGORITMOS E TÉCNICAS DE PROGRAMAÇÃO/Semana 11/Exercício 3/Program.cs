//3. Construa uma função que calcule e retorne o número de ocorrências de valores iguais a zero em uma matriz de reais


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

        int qtZero = buscarZero(matriz);

    }

    static int buscarZero(double[,] matriz)
    {
        int cont = 0;

        for(int j = 0; j < matriz.GetLength(1); j++)
        {
            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                if(matriz[i, j] == 0)
                {
                    cont = cont + 1;
                }

            }
        }

        return cont;
        
    }
} 
