using System;

class Exercicio_2
{
    static void Main()
    {

        double[] vetor = {1.5, 2.5, 3.5, 4.5};

        int posicao = vetor.Length - 1;

        escrevaInvertido(vetor, posicao);
        
    }

    static void escrevaInvertido(double[] vetor, int posicao)
    {
        if(posicao < 0)
        {
            return;
        }

        Console.WriteLine(vetor[posicao]);

        posicao--;

        escrevaInvertido(vetor,posicao);
    }
}