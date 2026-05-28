//Construa uma função que calcule a média dos valores presentes em sua diagonal principal. Teste-a a partir da função principal.
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
        

        double media = buscarMediaDiagonalPrincipal(matriz);

    }

    static double buscarMediaDiagonalPrincipal(double[,] matriz)
    {
        if(matriz.GetLength(0) != matriz.GetLength(1))
        {
            return 0;
        }
        double somaDiagonal = 0;
        int contDiagonal = 0;
        
            for(int j = 0; j < matriz.GetLength(1); j++)
            {
                for(int i = 0; i < matriz.GetLength(0); i++)
                {
                    if(i == j)
                    {
                        somaDiagonal = somaDiagonal + matriz[i,j];
                        contDiagonal = contDiagonal + 1;
                    }

                }
            }

        double media = somaDiagonal / (double) contDiagonal;  
        
        return media;
        
    }
}  