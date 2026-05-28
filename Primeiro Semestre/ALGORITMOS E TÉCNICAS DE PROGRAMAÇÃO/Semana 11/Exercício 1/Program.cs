//1. Construa uma função que receba uma matriz quadrada de reais. A função deverá visitar e escrever os elementos posicionados acima da diagonal principal. Caso a função não receba uma matriz quadrada, ela deverá retornar o valor zero.


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

        escrevaAcimaDiagonal(matriz);
    }

    static void escrevaAcimaDiagonal(double[,] matriz)
    {
        if(matriz.GetLength(0) != matriz.GetLength(1)){

            Console.WriteLine(0);
        }

        for(int j = 0; j < matriz.GetLength(1); j++)
        {
            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                if(i < j)
                {

                    Console.WriteLine(matriz[i,j]);
                
                }
            }
        }
        
    }
}   