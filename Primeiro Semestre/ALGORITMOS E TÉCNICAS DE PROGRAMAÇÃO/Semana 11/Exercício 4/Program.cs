//4. Construa uma função que verifique se uma matriz de reais contém ou não algum valor igual a zero. A função deverá retornar verdadeiro, se houver, ou falso, caso contrário.


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

        bool temZero = buscarZero(matriz);

    }

    static bool buscarZero(double[,] matriz)
    {

            for(int j = 0; j < matriz.GetLength(1); j++)
            {
                for(int i = 0; i < matriz.GetLength(0); i++)
                {
                    if(matriz[i, j] == 0)
                    {
                        return true;
                    }

                }
            }  
        
        return false;
        
    }
}  