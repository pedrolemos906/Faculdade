using System;

public class PilhaChamadas
{
    public void pilha()
    {
        int n = int.Parse(Console.ReadLine());

        Exibir(n);
    }

    public void Exibir(int n)
    {
        if (n == 0)
        {
            return;
        }

        Console.WriteLine("Antes: " + n);

        Exibir(n - 1);

        Console.WriteLine("Depois: " + n);
    }
}