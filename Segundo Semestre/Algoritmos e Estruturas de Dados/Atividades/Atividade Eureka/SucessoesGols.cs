using System;

public class SucessoesGols
{
    public void gerarSucessoes()
    {
        string[] entrada = Console.ReadLine().Split();

        int m = int.Parse(entrada[0]);
        int n = int.Parse(entrada[1]);

        string sequencia = "";

        Gerar(m, n, sequencia);
    }

    public void Gerar(int golsA, int golsB, string sequencia)
    {
        if (golsA == 0 && golsB == 0)
        {
            Console.WriteLine(sequencia.Trim());
            return;
        }

        if (golsA > 0)
        {
            Gerar(golsA - 1, golsB, sequencia + "A ");
        }

        if (golsB > 0)
        {
            Gerar(golsA, golsB - 1, sequencia + "B ");
        }
    }
}