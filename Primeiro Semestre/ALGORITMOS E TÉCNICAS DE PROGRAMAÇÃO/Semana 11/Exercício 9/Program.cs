//9. Construa uma função que receba uma matriz quadrada de reais. A função deverá retornar a média dos valores posicionados abaixo da diagonal principal.
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

        

        double ehIgual = buscarMediaAbaixodiagonal(matriz);

    }

    static double buscarMediaAbaixodiagonal(double[,] matriz) //i>j
    {
        if (matriz.GetLength(0) != matriz.GetLength(1))
        {
            return 0;
        }

        double soma = 0;
        int cont = 0;

        for (int y = 0; y < matriz.GetLength(1); y++)
        {
            for (int x = 0; x < matriz.GetLength(0); x++)
            {
                if(x > y)
                {
                    soma = soma + matriz[x,y];
                    cont = cont + 1;    
                }
               

            }
        }

        return soma / (double) cont;

    }
}