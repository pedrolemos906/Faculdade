using System;

public class InverterVetor
{
    public void criarVetor()
    {
        int[] vetor = { 10, 20, 30, 40, 50 };

        Inverter(vetor, 0, vetor.Length - 1);

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i] + " ");
        }
    }

    public void Inverter(int[] vetor, int inicio, int fim)
    {
        if (inicio >= fim)
        {
            return;
        }

        int aux = vetor[inicio];
        vetor[inicio] = vetor[fim];
        vetor[fim] = aux;

        Inverter(vetor, inicio + 1, fim - 1);
    }
}