//2. Construa uma função que calcule e retorne o maior valor presente em uma matriz de reais.


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

        double maior = buscarMaior(matriz);

    }

    static double buscarMaior(double[,] matriz)
    {
        double maior = 0;

        for(int j = 0; j < matriz.GetLength(1); j++)
        {
            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                if(maior < matriz[i, j])
                {
                    maior = matriz[i,j];
                }

            }
        }

        return maior;
        
    }
}   