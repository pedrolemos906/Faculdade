using System;

class Exercicio_1
{
    static void Main()
    {
        int posicao = 0;

        double[] vetor = {1.5, 2.5, 3.5, 4.5};

        escrever(vetor, posicao);
        
    }

    static void escrever(double[] vetor, int posicao)
    {
        if(posicao == vetor.Length)
        {
            return;
        }

        Console.WriteLine(vetor[posicao]);

        posicao++;

        escrever(vetor,posicao);
    }
}