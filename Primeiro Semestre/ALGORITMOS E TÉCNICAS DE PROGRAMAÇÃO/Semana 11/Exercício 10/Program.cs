//10. Construa uma função que receba uma matriz quadrada de reais. A função deverá retornar a soma dos valores que compõem sua diagonal secundária.
using System;
using System.Dynamic;

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

        

        double soma = buscarDiagonalSecundaria(matriz);

    }

    static double buscarDiagonalSecundaria(double[,] matriz)
    {
        if (matriz.GetLength(0) != matriz.GetLength(1))
        {
            return 0;
        }
        
        double soma = 0;

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            int j = matriz.GetLength(1)-1 - i; 
            
            soma = soma + matriz[i,j];
        }
        

        return soma;

    }
}