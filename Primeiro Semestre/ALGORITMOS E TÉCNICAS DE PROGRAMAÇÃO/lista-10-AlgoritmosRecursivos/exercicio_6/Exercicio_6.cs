using System;


class Exercicio_6
{
    static void Main()
    {
        double[] conjunto = {1,2,3,4,-5,-8,10};

        int posicao = 0;

        escrevaPositivo(conjunto, posicao);
    }

    static void escrevaPositivo(double[] conjunto, int posicao)
    {
        if(posicao == conjunto.Length)
        {
            return;            
        }
        
        else if (conjunto[posicao] > 0)
        {
            Console.WriteLine(conjunto[posicao]);
        }

        escrevaPositivo(conjunto, posicao + 1);
    
    }
}